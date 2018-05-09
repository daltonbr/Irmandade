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
        PessoaRepository repo = new PessoaRepository();
        ServicoRepository servicoRepo = new ServicoRepository();
        BaseRepository baseRepo = new BaseRepository();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CarregaDiasDaSemana();
            CarregaDados();
            CarregaServicos();
        }

        private void CarregaDados()
        {
            DataTable dt = new DataTable();
            //SQLiteConnection conn = null;
            string sql = "SELECT * FROM Pessoas";            
            //String strConn = @strings.connectionString;
            try
            {
                //conn = new SQLiteConnection(strConn);
                //SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
                //da.Fill(dt);
                dt = baseRepo.GetDataTableFromConnection<SQLiteConnection>(sql);
                dataGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open)
                //{
                //    conn.Close();
                //}
            }
        }

        private void CarregaDiasDaSemana()
        {
            checkedListBox.DataSource = Enum.GetValues(typeof(Dias));
        }


        private void CarregaServicos()
        {
            DataTable dt = new DataTable();
            //SQLiteConnection conn = null;
            string sql = "SELECT * FROM Servicos ORDER BY Descricao";
            //string strConn = @strings.connectionString;
            try
            {
                //conn = new SQLiteConnection(strConn);
                //SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
                //da.Fill(dt);
                dt = baseRepo.GetDataTableFromConnection<SQLiteConnection>(sql);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    //listBox.Items.Add(dr[1]);
                    comboBox.Items.Add(dr[1]);
                }
                //dataGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                //if (conn.State == ConnectionState.Open)
                //{
                //    conn.Close();
                //}
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //MessageBoxResult result = MessageBox.Show("Deseja realmente sair?", "Irmandade", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //if (result == MessageBoxResult.Yes)
            //{
                Close();
            //}
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Concatenates the SQL Query suffix
            var servicosList = new List<string>();

            var selected = listBox.SelectedItems;

            foreach (var item in selected)
            {                
                servicosList.Add(@" """ + item.ToString() + @""" ");
            }

            string sqlSuffix = string.Join(" OR ", servicosList);

            if (sqlSuffix != "")
            {
                sqlSuffix = "WHERE S.Descricao = " + sqlSuffix;
            }

            string sql = @"SELECT * FROM Pessoas P
                           INNER JOIN Pessoas_Servicos PS
                                ON (P.CPF = PS.Pessoa_CPF)
                           INNER JOIN Servicos S
                                ON (PS.Servico_Id = S.Id)
                            " + sqlSuffix;
            testLabel.Text = sqlSuffix;

            DataTable dt = baseRepo.GetDataTableFromConnection<SQLiteConnection>(sql);
            dataGridView.DataSource = dt.DefaultView;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = null;
                IndividualForm iForm = new IndividualForm(pessoa); // passar _pessoa como parametro
                iForm.ShowDialog();
                CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string CPF = GetPessoaCPFFromActiveRow();
            //TODO MessageBox when cannot get valid CPF
            // TODO garantir que temos uma linha selecionada (talvez botao disabled)
            Pessoa pessoa = repo.GetPessoa(CPF);

            try
            {
                IndividualForm iform = new IndividualForm(pessoa);
                iform.ShowDialog();
                CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

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
        
        //private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Display in a message box all the items that are checked.

        //    int bitwiseSum = 0;
        //    // First show the index and check state of all selected items.
        //    foreach (int indexChecked in checkedListBox.CheckedIndices)
        //    {
        //        bitwiseSum += (int)Math.Pow(2,(indexChecked));
        //        // The indexChecked variable contains the index of the item.
        //        //MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
        //        //                checkedListBox.GetItemCheckState(indexChecked).ToString() + ".");
        //    }

        //    label.Text = bitwiseSum.ToString();

        //    // Next show the object title and check state for each item selected.
        //    //foreach (object itemChecked in checkedListBox.CheckedItems)
        //    //{

        //    //    // Use the IndexOf method to get the index of an item.
        //    //    MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
        //    //                    "\", is checked. Checked state is: " +
        //    //                    checkedListBox.GetItemCheckState(checkedListBox.Items.IndexOf(itemChecked)).ToString() + ".");
        //    //}

        //    //var collection = checkedListBox.SelectedIndices;

        //    //List<int> selectedItemIndexes = new List<int>();
        //    //foreach (object o in checkedListBox.SelectedItems)
        //    //    selectedItemIndexes.Add(checkedListBox.Items.IndexOf(o));

        //    //string test = "";
        //    //var i = 0;
        //    //foreach(var v in selectedItemIndexes)
        //    //{
        //    //    i++;           
        //    //    test += v.ToString() + ", ";
        //    //}
        //    //label.Text = i.ToString();
        //}

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult response = MessageBox.Show("Deseja REMOVER este voluntário?", "Remover Voluntario",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    DeletaDados(GetPessoaCPFFromActiveRow());
                    //TODO make a verication above
                    CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        public int DeletaDados(string CPF)
        {
            int resultado = -1;
            //using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteConnection conn = BaseRepository.DbConnection())
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = repo.ProcurarPessoas(nameSearchTextBox.Text);
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            // TODO check if we always have 5 Item
            dataGridView.DataSource = repo.ProcurarPessoas(checkedListBox.GetItemChecked(0),
                                                           checkedListBox.GetItemChecked(1),
                                                           checkedListBox.GetItemChecked(2),
                                                           checkedListBox.GetItemChecked(3),
                                                           checkedListBox.GetItemChecked(4));
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.editButton_Click(editButton, e);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Concatenates the SQL Query suffix
            var servicosList = new List<string>();           

            string sqlSuffix = "WHERE S.Descricao = " + @" """ + comboBox.SelectedItem.ToString() + @""" ";

            string sql = @"SELECT * FROM Pessoas P
                           INNER JOIN Pessoas_Servicos PS
                                ON (P.CPF = PS.Pessoa_CPF)
                           INNER JOIN Servicos S
                                ON (PS.Servico_Id = S.Id)
                            " + sqlSuffix;

            testLabel.Text = sqlSuffix;

            DataTable dt = baseRepo.GetDataTableFromConnection<SQLiteConnection>(sql);
            dataGridView.DataSource = dt.DefaultView;
        }
    }
}
