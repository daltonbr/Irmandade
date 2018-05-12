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
            LoadMainQuery();
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
           

            //MessageBox.Show(nome + servico + diasDisponiveis[0].ToString());

            //dataGridView.DataSource = Repository.Instance.GetPessoasByDiasDisponiveis(diasCheckedListBox.GetItemChecked(0),
            //                                                           diasCheckedListBox.GetItemChecked(1),
            //                                                           diasCheckedListBox.GetItemChecked(2),
            //                                                           diasCheckedListBox.GetItemChecked(3),
            //                                                           diasCheckedListBox.GetItemChecked(4));            

            //dataGridView.DataSource = Repository.Instance.GetPessoasByNome(nameSearchTextBox.Text);
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
                IndividualForm iForm = new IndividualForm(pessoa); // passar _pessoa como parametro
                iForm.ShowDialog();
                LoadMainQuery();
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
                LoadMainQuery();
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
                DialogResult response = MessageBox.Show("Deseja REMOVER este voluntário?", "Remover Voluntario",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    DeletePessoaByCPF(GetPessoaCPFFromActiveRow());                    
                    LoadMainQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // TODO put this message box to work in release version
            //MessageBoxResult result = MessageBox.Show("Deseja realmente sair?", "Irmandade", MessageBoxButton.YesNo, MessageBoxImage.Question);
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

        public int DeletePessoaByCPF(string CPF)
        {
            int resultado = -1;            
            using (SQLiteConnection conn = Repository.DbConnection())
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM Pessoas WHERE CPF = @CPF";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    try
                    {
                        resultado = cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return resultado;
        }

        private void nameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadMainQueryComposed();
            dataGridView.DataSource = Repository.Instance.GetPessoasByNome(nameSearchTextBox.Text);
        }

        private void diasCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMainQueryComposed();
            dataGridView.DataSource = Repository.Instance.GetPessoasByDiasDisponiveis(diasCheckedListBox.GetItemChecked(0),
                                                                       diasCheckedListBox.GetItemChecked(1),
                                                                       diasCheckedListBox.GetItemChecked(2),
                                                                       diasCheckedListBox.GetItemChecked(3),
                                                                       diasCheckedListBox.GetItemChecked(4));
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.editButton_Click(editButton, e);
        }

        private void servicosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMainQueryComposed();
            if (servicosComboBox.SelectedIndex == -1) return;                                   

            string sql = @"SELECT * FROM Pessoas P
                           INNER JOIN Pessoas_Servicos PS
                                ON (P.CPF = PS.Pessoa_CPF)
                           INNER JOIN Servicos S
                                ON (PS.Servico_Id = S.Id)
                            WHERE S.Descricao = " + @" """ + servicosComboBox.SelectedItem.ToString() + @""" ";

            DataTable dt = Repository.Instance.GetDataTableFromConnection<SQLiteConnection>(sql);
            dataGridView.DataSource = dt.DefaultView;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            nameSearchTextBox.Text = "";
            servicosComboBox.SelectedIndex = -1;
            diasCheckedListBox.ClearSelected();
            foreach (int i in diasCheckedListBox.CheckedIndices)
            {
                diasCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
            LoadMainQuery();
        }

    }
}
