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
            CarregaDados();
            CarregaServicos();
            CarregaDiasDaSemana();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");
            //Console.WriteLine(Irmandade.strings.monday);
            label.Text = strings.thursday;
        }

        private void CarregaDados()
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = null;
            String sql = "select * from Pessoas";
            String strConn = @"Data Source=C:\Irmandade\database\VoluntariosDB.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
                da.Fill(dt);
                dataGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void CarregaDiasDaSemana()
        {
            List<string> diasDaSemana = new List<string> { "seg", "ter", "qua", "qui", "sex" };
            List<Days> dias = new List<Days> { Days.Monday, Days.Tuesday };

            //DayOfWeek monday = DayOfWeek.Monday;
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday };

            for (int i = 0; i < dias.Count; i++)
            {                
                //listBox.Items.Add(diasDaSemana[i]);
                checkedListBox.Items.Add(dias[i]);
            }

            listBox.DataSource = Enum.GetValues(typeof(Days));

            //for (int i = 0; i < days.Length; i++)
            //{
            //    listBox.Items.Add(days[i]);
            //    //checkedListBox.Items.Add(days[i]);
            //}

        }

        private void CarregaServicos()
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = null;
            String sql = "select * from Servicos";
            String strConn = @"Data Source=C:\Irmandade\database\VoluntariosDB.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
                da.Fill(dt);

                for(int i = 0; i < dt.Rows.Count; i++)
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label.Text = listBox.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            try
            {
                IndividualForm iform = new IndividualForm(GetDadosDoGrid());
                iform.ShowDialog();
                CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private Pessoa GetDadosDoGrid()
        {
            try
            {
                int linha;
                linha = dataGridView.CurrentRow.Index;
                Pessoa pessoa = new Pessoa();
                // TODO improve this
                pessoa.CPF = dataGridView[0, linha].Value.ToString();
                pessoa.Nome = dataGridView[1, linha].Value.ToString();
                pessoa.Email = dataGridView[2, linha].Value.ToString();                
                return pessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
