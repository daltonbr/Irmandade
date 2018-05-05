using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using System.Windows.Input;

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
                    listBox.Items.Add(dr[1]);
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

        }
    }
}
