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
using System.Data.SQLite;

namespace Irmandade
{
    public partial class IndividualForm : Form
    {

        Pessoa _pessoa;
        string operacao = "";
        string connectionString = @"Data Source=C:\Irmandade\database\VoluntariosDB.db";
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
            if (_pessoa == null)
            {
                saveButton.Enabled = true;
                nomeTextBox.Focus();
                operacao = "incluir";
            }
            else
            {
                operacao = "alterar";
                nomeTextBox.Text = _pessoa.Nome;
                CPFTextBox.Text = _pessoa.CPF;
                emailTextBox.Text = _pessoa.Email;
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
                pessoa.DiasDisponiveis = getDiasDisponiveis();
                                
                try
                {
                    if (operacao == "incluir")
                    {
                        if (IncluirDados(pessoa) > 0)
                        {
                            MessageBox.Show("Dados incluídos com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Os dados não foram incluídos.");
                        }
                    }
                    else
                    {
                        if (AtualizaDados(pessoa) > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Os dados não foram atualizados.");
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
                MessageBox.Show("Dados inválidos.");
            }
        }

        // TODO improve this verification
        private Boolean ValidaDados()
        {
            bool retorno = true;
            if (nomeTextBox.Text == string.Empty)
                retorno = false;
            if (emailTextBox.Text == string.Empty)
                retorno = false;
            if (CPFTextBox.Text == string.Empty)
                retorno = false;
            return retorno;
        }

        public int getDiasDisponiveis()
        {
            // TODO check the bitwise integer from the diasDisponiveis Checklist
            return 5;
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Pessoas(CPF, RG, RGEmissor, Nome, Endereco, TelefoneFixo, TelefoneCelular, InicioDasAtividades, Observacoes, Email, DiasDisponiveis) " +
                                       "VALUES (@CPF, @RG, @RGEmissor, @Nome, @Endereco, @TelefoneFixo, @TelefoneCelular, @InicioDasAtividades, @Observacoes, @Email, @DiasDisponiveis)";
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
                    cmd.Parameters.AddWithValue("@DiasDisponiveis", pessoa.DiasDisponiveis);
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE Pessoas SET RG=@RG, RGEmissor=@RGEmissor, Endereco=@Endereco, Nome=@Nome, TelefoneFixo=@TelefoneFixo, TelefoneCelular=@TelefoneCelular, InicioDasAtividades=@InicioDasAtividades, Observacoes=@Observacoes, Email=@Email, DiasDisponiveis=@DiasDisponiveis WHERE CPF = @CPF";
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
                    cmd.Parameters.AddWithValue("@DiasDisponiveis", pessoa.DiasDisponiveis);
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
    }

}