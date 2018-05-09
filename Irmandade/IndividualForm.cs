using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irmandade.Model;
using Irmandade.Data;
using System.Data.SQLite;

namespace Irmandade
{
    public partial class IndividualForm : Form
    {
        BaseRepository baseRepo = new BaseRepository();

        Pessoa _pessoa;
        string operacao = "";        
                
        public IndividualForm(Pessoa pessoa)
        {
            _pessoa = pessoa;
            InitializeComponent();
            // TODO use a nested constructor              
        }

        public IndividualForm()
        {
            InitializeComponent();
        }

        private void IndividualForm_Load(object sender, EventArgs e)
        {
            diasCheckedListBox.DataSource = Enum.GetValues(typeof(Dias));

            if (_pessoa == null)
            {
                saveButton.Enabled = true;
                nomeTextBox.Focus();
                operacao = "incluir";
            }
            else
            {
                operacao = "alterar";
                CPFTextBox.Text = _pessoa.CPF;
                RGTextBox.Text = _pessoa.RG;                
                emissorTextBox.Text = _pessoa.RGEmissor;
                nomeTextBox.Text = _pessoa.Nome;
                enderecoTextBox.Text = _pessoa.Endereco;
                telefoneFixoTextBox.Text = _pessoa.TelefoneFixo;
                telefoneCelularTextBox.Text = _pessoa.TelefoneCelular;
                dateTimePicker.Text = _pessoa.InicioDasAtividades;
                observacoesTextBox.Text = _pessoa.Observacoes;
                emailTextBox.Text = _pessoa.Email;

                diasCheckedListBox.SetItemChecked(0, _pessoa.DisponivelSegunda == 1);
                diasCheckedListBox.SetItemChecked(1, _pessoa.DisponivelTerca == 1);
                diasCheckedListBox.SetItemChecked(2, _pessoa.DisponivelQuarta == 1);
                diasCheckedListBox.SetItemChecked(3, _pessoa.DisponivelQuinta == 1);
                diasCheckedListBox.SetItemChecked(4, _pessoa.DisponivelSexta == 1);

                // Query servicos

                // Concatenates the SQL Query suffix
                //var servicosList = new List<string>();

                //string sqlSuffix = "WHERE S.Descricao = " + @" """ + comboBox.SelectedItem.ToString() + @""" ";

                string sql = @"SELECT S.Descricao FROM Pessoas_Servicos PS
                               INNER JOIN Pessoas P
                                    ON (PS.Pessoa_CPF = P.CPF)
                               NATURAL JOIN Servicos S                                    
                               WHERE P.CPF = " + @" """ + _pessoa.CPF + @""" ";
                
                DataTable dt = baseRepo.GetDataTableFromConnection<SQLiteConnection>(sql);
                DataColumn dc = dt.Columns[0];

                //servicosListBox.DataSource = dc;
                //servicosListBox.DataSource = dt.DefaultView;

                //List<Servico> servicos = new List<Servico>();
                //servicos.Add(new Servico { })

                //List<int> ids = new List<int>(dt.Rows.Count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //servicosListBox.Items.Add(dt[0]);
                }               
            }
        }      

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.CPF = CPFTextBox.Text;
                pessoa.RG = RGTextBox.Text;
                pessoa.RGEmissor = emissorTextBox.Text;
                pessoa.Nome = nomeTextBox.Text;
                pessoa.Endereco = enderecoTextBox.Text;
                pessoa.TelefoneFixo = telefoneFixoTextBox.Text;
                pessoa.TelefoneCelular = telefoneCelularTextBox.Text;
                pessoa.InicioDasAtividades = dateTimePicker.Text;
                pessoa.Observacoes = observacoesTextBox.Text;
                pessoa.Email = emailTextBox.Text;
                pessoa.DisponivelSegunda = diasCheckedListBox.GetItemCheckState(0) == CheckState.Unchecked ? 0 : 1;
                pessoa.DisponivelTerca   = diasCheckedListBox.GetItemCheckState(1) == CheckState.Unchecked ? 0 : 1;
                pessoa.DisponivelQuarta  = diasCheckedListBox.GetItemCheckState(2) == CheckState.Unchecked ? 0 : 1;
                pessoa.DisponivelQuinta  = diasCheckedListBox.GetItemCheckState(3) == CheckState.Unchecked ? 0 : 1;
                pessoa.DisponivelSexta   = diasCheckedListBox.GetItemCheckState(4) == CheckState.Unchecked ? 0 : 1;

                try
                {
                    if (operacao == "incluir")
                    {
                        if (IncluirDados(pessoa) > 0)
                        {
                            MessageBox.Show("Dados incluídos com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Os dados não foram incluídos!");
                        }
                    }
                    else
                    {
                        if (AtualizaDados(pessoa) > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Os dados não foram atualizados!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Registo NÃO inserido!");
            }
        }

        // TODO improve this verification
        private Boolean ValidaDados()
        {            
            if (nomeTextBox.Text == string.Empty)
            {
                MessageBox.Show("Erro : " + "Campo Nome inválido!");
                return false;
            }
            if (CPFTextBox.Text == string.Empty)
            {
                MessageBox.Show("Erro : " + "Campo CPF inválido!");
                return false;
            }
            return true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        public int IncluirDados(Pessoa pessoa)
        {            
            int resultado = -1;
            //using (SQLiteConnection conn = new SQLiteConnection(@strings.connectionString))
            using (SQLiteConnection conn = BaseRepository.DbConnection())
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Pessoas(CPF, RG, RGEmissor, Nome, Endereco, TelefoneFixo, TelefoneCelular, InicioDasAtividades, Observacoes, Email, DisponivelSegunda, DisponivelTerca, DisponivelQuarta, DisponivelQuinta, DisponivelSexta) " +
                                       "VALUES (@CPF, @RG, @RGEmissor, @Nome, @Endereco, @TelefoneFixo, @TelefoneCelular, @InicioDasAtividades, @Observacoes, @Email, @DisponivelSegunda, @DisponivelTerca, @DisponivelQuarta, @DisponivelQuinta, @DisponivelSexta)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@CPF", pessoa.CPF);
                    cmd.Parameters.AddWithValue("@RG", pessoa.RG);
                    cmd.Parameters.AddWithValue("@RGEmissor", pessoa.RGEmissor);
                    cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@TelefoneFixo", pessoa.TelefoneFixo);
                    cmd.Parameters.AddWithValue("@TelefoneCelular", pessoa.TelefoneCelular);
                    cmd.Parameters.AddWithValue("@InicioDasAtividades", pessoa.InicioDasAtividades);
                    cmd.Parameters.AddWithValue("@Observacoes", pessoa.Observacoes);
                    cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                    cmd.Parameters.AddWithValue("@DisponivelSegunda", pessoa.DisponivelSegunda);
                    cmd.Parameters.AddWithValue("@DisponivelTerca", pessoa.DisponivelTerca);
                    cmd.Parameters.AddWithValue("@DisponivelQuarta", pessoa.DisponivelQuarta);
                    cmd.Parameters.AddWithValue("@DisponivelQuinta", pessoa.DisponivelQuinta);
                    cmd.Parameters.AddWithValue("@DisponivelSexta", pessoa.DisponivelSexta);
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

        public int AtualizaDados(Pessoa pessoa)
        {
            int resultado = -1;
            //using (SQLiteConnection conn = new SQLiteConnection(@strings.connectionString))
            using (SQLiteConnection conn = BaseRepository.DbConnection())
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE Pessoas SET RG=@RG, RGEmissor=@RGEmissor, Endereco=@Endereco, Nome=@Nome, TelefoneFixo=@TelefoneFixo, TelefoneCelular=@TelefoneCelular, InicioDasAtividades=@InicioDasAtividades, Observacoes=@Observacoes, Email=@Email, DisponivelSegunda=@DisponivelSegunda, DisponivelTerca=@DisponivelTerca, DisponivelQuarta=@DisponivelQuarta, DisponivelQuinta=@DisponivelQuinta, DisponivelSexta=@DisponivelSexta WHERE CPF = @CPF";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@CPF", pessoa.CPF);
                    cmd.Parameters.AddWithValue("@RG", pessoa.RG);
                    cmd.Parameters.AddWithValue("@RGEmissor", pessoa.RGEmissor);
                    cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@TelefoneFixo", pessoa.TelefoneFixo);
                    cmd.Parameters.AddWithValue("@TelefoneCelular", pessoa.TelefoneCelular);
                    cmd.Parameters.AddWithValue("@InicioDasAtividades", pessoa.InicioDasAtividades);
                    cmd.Parameters.AddWithValue("@Observacoes", pessoa.Observacoes);
                    cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                    cmd.Parameters.AddWithValue("@DisponivelSegunda", pessoa.DisponivelSegunda);
                    cmd.Parameters.AddWithValue("@DisponivelTerca", pessoa.DisponivelTerca);
                    cmd.Parameters.AddWithValue("@DisponivelQuarta", pessoa.DisponivelQuarta);
                    cmd.Parameters.AddWithValue("@DisponivelQuinta", pessoa.DisponivelQuinta);
                    cmd.Parameters.AddWithValue("@DisponivelSexta", pessoa.DisponivelSexta);                    
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            // TODO check for editions before closing!
            Close();
        }

        private void removeServicoButton_Click(object sender, EventArgs e)
        {

        }
    }

}