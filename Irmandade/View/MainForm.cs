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
            LoadServicosIntoCombobox();
        }

        /// <summary>
        /// Main query of this form
        /// </summary>
        private void LoadMainQueryComposed()
        {
            dataGridView.Columns.Clear();            
            
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

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = Repository.Instance.GetPessoasByNomeServicoDiasDisponiveis(nome, servico, diasDisponiveis);            
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Code", DataPropertyName="CPF" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nome", DataPropertyName = "Nome" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fone Fixo", DataPropertyName = "TelefoneFixo" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Celular", DataPropertyName = "TelefoneCelular" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "SEG", DataPropertyName = "DisponivelSegunda" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "TER", DataPropertyName = "DisponivelTerca" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "QUA", DataPropertyName = "DisponivelQuarta" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "QUI", DataPropertyName = "DisponivelQuinta" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { Name = "SEX", DataPropertyName = "DisponivelSexta" });

            dataGridView.AutoResizeColumns();            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;            
        }

        /// <summary>
        /// Old and simple main query
        /// </summary>
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
        
        private void LoadServicosIntoCombobox()
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

        /// <summary>
        /// Clear all the query filter inputs
        /// </summary>        
        private void cleanButton_Click(object sender, EventArgs e)
        {
            nameSearchTextBox.Text = "";
            servicosComboBox.SelectedIndex = -1;
            diasCheckedListBox.ClearSelected();
            foreach (int i in diasCheckedListBox.CheckedIndices)
            {
                diasCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
            LoadMainQueryComposed();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = null;
                IndividualForm iForm = new IndividualForm(pessoa);
                iForm.ShowDialog();
                LoadMainQueryComposed();
                LoadServicosIntoCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                string CPF = GetPessoaCPFFromActiveRow();
                Pessoa pessoa = Repository.Instance.GetPessoaByCPF(CPF);
                IndividualForm iform = new IndividualForm(pessoa);
                iform.Show();
                LoadMainQueryComposed();
                LoadServicosIntoCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                LoadMainQueryComposed();
                LoadServicosIntoCombobox();
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
                // TODO this method could be improved
                // a line must be selected AND CPF must be in the first column
                int row = dataGridView.CurrentRow.Index;                
                return dataGridView[0, row].Value.ToString();                
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repository.SaveDatabase();
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
