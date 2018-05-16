﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Irmandade.Model;
using Irmandade.Data;
using System.IO;

namespace Irmandade.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMainQueryComposed();
            LoadServicos();
        }

        private void LoadMainQueryComposed()
        {
            // read inputs            
            string nome = nameSearchTextBox.Text;
            string servico = "";
            if (servicosComboBox.SelectedIndex != -1)
            { servico = servicosComboBox.SelectedItem.ToString(); }
            bool[] diasDisponiveis = { diasCheckedListBox.GetItemChecked(0),
                                    diasCheckedListBox.GetItemChecked(1),
                                    diasCheckedListBox.GetItemChecked(2),
                                    diasCheckedListBox.GetItemChecked(3),
                                    diasCheckedListBox.GetItemChecked(4) };

            dataGridView.DataSource = Repository.Instance.GetPessoasByNomeServicoDiasDisponiveis(nome, servico, diasDisponiveis);
            //dataGridView.Columns[0].Name = "Code ";
            //dataGridView.Columns[1].Width = 200;    // Nome
            //dataGridView.Columns[2].Width = 200;    // Email
            dataGridView.Columns[3].HeaderText = "Telefone Fixo";
            dataGridView.Columns[4].HeaderText = "Celular";
            dataGridView.Columns[5].HeaderText = "SEG";
            dataGridView.Columns[6].HeaderText = "TER";
            dataGridView.Columns[7].HeaderText = "QUA";
            dataGridView.Columns[8].HeaderText = "QUI";
            dataGridView.Columns[9].HeaderText = "SEX";

            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridView.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //DataGridViewColumn amount = new DataGridViewColumn();
            //amount.HeaderText = "Amount";
            //amount.Name = "Amount";
            //dataGridView.Columns.Insert(3, amount);
        }

        private void LoadMainQuery()
        {
            DataTable dt = new DataTable();            
            string sql = "SELECT * FROM Pessoas";            
            try
            {                
                dt = Repository.Instance.GetDataTableFromConnection<SQLiteConnection>(sql);
                dataGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }            
        }

        private void LoadServicos()
        {
            servicosComboBox.Items.Clear();
            DataTable dt = new DataTable();            
            string sql = "SELECT * FROM Servicos ORDER BY Descricao";            
            try
            {                
                dt = Repository.Instance.GetDataTableFromConnection<SQLiteConnection>(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];                    
                    servicosComboBox.Items.Add(dr[1]);
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }            
        }

        #region Buttons

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = null;
                IndividualForm iForm = new IndividualForm(pessoa);
                iForm.ShowDialog();
                LoadMainQueryComposed();
                LoadServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string CPF = GetPessoaCPFFromActiveRow();
            //TODO MessageBox when cannot get valid CPF            
            Pessoa pessoa = Repository.Instance.GetPessoaByCPF(CPF);

            try
            {
                IndividualForm iform = new IndividualForm(pessoa);
                iform.ShowDialog();
                LoadMainQueryComposed();                
                LoadServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult response = MessageBox.Show($"Deseja REMOVER o voluntário de CPF {GetPessoaCPFFromActiveRow()}?", "ATENÇÃO! Remover Voluntario",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    Repository.Instance.DeletePessoaByCPF(GetPessoaCPFFromActiveRow());
                    LoadMainQueryComposed();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Voluntário não removido!" + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Deseja realmente sair?", "Irmãs do Imaculado Coração de Maria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion

        public string GetPessoaCPFFromActiveRow()
        {            
            try
            {
                int linha = dataGridView.CurrentRow.Index;
                // Todo improve check
                return dataGridView[0, linha].Value.ToString();                
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }        

        private void nameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadMainQueryComposed();
        }

        private void diasCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMainQueryComposed();            
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.editButton_Click(editButton, e);
        }

        private void servicosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMainQueryComposed();            
            //if (servicosComboBox.SelectedIndex == -1) return;                                   

            //string sql = @"SELECT * FROM Pessoas P
            //               INNER JOIN Pessoas_Servicos PS
            //                    ON (P.CPF = PS.Pessoa_CPF)
            //               INNER JOIN Servicos S
            //                    ON (PS.Servico_Id = S.Id)
            //                WHERE S.Descricao = " + @" """ + servicosComboBox.SelectedItem.ToString() + @""" ";

            //DataTable dt = Repository.Instance.GetDataTableFromConnection<SQLiteConnection>(sql);
            //dataGridView.DataSource = dt.DefaultView;
        }

        /// <summary>
        /// Clear all the query filter inputs
        /// </summary>
        /// <param name="sender"></param>
        private void cleanButton_Click(object sender, EventArgs e)
        {
            nameSearchTextBox.Text = "";
            servicosComboBox.SelectedIndex = -1;
            diasCheckedListBox.ClearSelected();
            foreach (int i in diasCheckedListBox.CheckedIndices)
            {
                diasCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repository.SaveDatabase();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inserirVoluntárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertButton_Click(sender, e);
        }

        private void editarVoluntárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton_Click(sender, e);
        }

        private void excluirVoluntárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult response = MessageBox.Show($"Deseja REMOVER o voluntário de CPF {GetPessoaCPFFromActiveRow()}?", "ATENÇÃO! Remover Voluntario",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    Repository.Instance.DeletePessoaByCPF(GetPessoaCPFFromActiveRow());
                    LoadMainQueryComposed();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Voluntário não removido!" + ex.Message);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicoForm form = new ServicoForm();
            form.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsForm credits = new CreditsForm();
            credits.Show();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Repository.RestoreDatabase();
            LoadMainQueryComposed();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show($"Atenção! Deseja EXCLUIR TODOS OS Dados do Sistema?", "ATENÇÃO! Exclusão de dados!",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.Yes)
            {
                DialogResult response2 = MessageBox.Show($"Atenção! Última confirmação: Deseja EXCLUIR TODOS OS Dados do Sistema? Esta operação é irreversível!", "ATENÇÃO! Exclusão de dados!",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (response2 == DialogResult.Yes)
                {
                    Repository.Instance.DeleteDataFromAllTables();
                    LoadMainQueryComposed();
                }
            }
        }

    }

}
