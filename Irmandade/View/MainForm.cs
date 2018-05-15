using System;
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

namespace Irmandade
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
            // TODO put this message box to work in release version
            //MessageBoxResult result = MessageBox.Show("Deseja realmente sair?", "Irmãs do Imaculado Coração de Maria", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //if (result == MessageBoxResult.Yes)
            //{
                Close();
            //}
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
            Repository.RestoreDatabase();
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
    }
}
