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

namespace Irmandade.View
{
    enum operation
    {
        notDefined,
        insert,
        update
    };

    public partial class IndividualForm : Form
    {        
        Pessoa _pessoa;
        operation _operation = operation.notDefined;
                
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
                _operation = operation.insert;
            }
            else
            {
                _operation = operation.update;
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

                SetEnableOnAllInputElements(false);
             
                diasCheckedListBox.SetItemChecked(0, _pessoa.DisponivelSegunda == 1);
                diasCheckedListBox.SetItemChecked(1, _pessoa.DisponivelTerca == 1);
                diasCheckedListBox.SetItemChecked(2, _pessoa.DisponivelQuarta == 1);
                diasCheckedListBox.SetItemChecked(3, _pessoa.DisponivelQuinta == 1);
                diasCheckedListBox.SetItemChecked(4, _pessoa.DisponivelSexta == 1);
                
                UpdateServicos(_pessoa.CPF);
            }
        }

        private void SetEnableOnAllInputElements(bool enabled)
        {
            //CPFTextBox.Enabled = enabled;
            RGTextBox.Enabled = enabled;
            emissorTextBox.Enabled = enabled;
            nomeTextBox.Enabled = enabled;
            enderecoTextBox.Enabled = enabled;
            telefoneFixoTextBox.Enabled = enabled;
            telefoneCelularTextBox.Enabled = enabled;
            dateTimePicker.Enabled = enabled;
            observacoesTextBox.Enabled = enabled;
            emailTextBox.Enabled = enabled;
            diasCheckedListBox.Enabled = enabled;
            servicoGroupBox.Enabled = enabled;
            addServicoButton.Enabled = enabled;
            removeServicoButton.Enabled = enabled;
            saveButton.Enabled = enabled;
        }

        private void UpdateServicos(string CPF)
        {
            string sql = @"SELECT S.Descricao FROM Servicos S
                                INNER JOIN Pessoas_Servicos PS
                                   ON (PS.Servico_Id = S.Id)
                                INNER JOIN Pessoas P
                                   ON (P.CPF = PS.Pessoa_CPF)
                                   WHERE P.CPF = " + @" """ + _pessoa.CPF + @""" 
                                   ORDER BY S.Descricao";
                                   

            DataTable dt = Repository.Instance.GetDataTableFromConnection<SQLiteConnection>(sql);

            servicosListBox.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                servicosListBox.Items.Add(dr[0]);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
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
                    if (_operation == operation.insert)
                    {
                        if (InsertPessoa(pessoa) > 0)
                        {
                            MessageBox.Show("Dados incluídos com sucesso!");
                            _pessoa = pessoa;
                            _operation = operation.update;
                        }
                        else
                        {
                            MessageBox.Show("Os dados não foram incluídos!");
                        }
                    }
                    else
                    {
                        if (UpdatePessoa(pessoa) > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                            _operation = operation.update;
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
        private Boolean ValidateInputs()
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

        public int InsertPessoa(Pessoa pessoa)
        {            
            int resultado = -1;            
            using (SQLiteConnection conn = Repository.DbConnection())
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
                        // SQLException constraint 
                        if (ex.ErrorCode == 19)
                        {                            
                            MessageBox.Show("Erro: CPF já cadastrado!");
                        }                        
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

        public int UpdatePessoa(Pessoa pessoa)
        {
            int resultado = -1;            
            using (SQLiteConnection conn = Repository.DbConnection())
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
            if (servicosListBox.SelectedIndex == -1)
            {
                //editButton.Enabled = false;
                MessageBox.Show("Selecione um serviço para ser removido!");
                return;
            }
            removeServiceFromPessoa(servicosListBox.SelectedItem.ToString(), _pessoa.CPF);
            UpdateServicos(_pessoa.CPF);
        }

        private void servicosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addServicoButton_Click(object sender, EventArgs e)
        {
            if (_pessoa == null)
            {
                // We need first to add a Pessoa
                if (!ValidateInputs()) return;
                _pessoa = new Pessoa();
                _pessoa.CPF = CPFTextBox.Text;
                _pessoa.Nome = nomeTextBox.Text;
                _pessoa.InicioDasAtividades = dateTimePicker.Text;
                InsertPessoa(_pessoa);
                _operation = operation.update;
            }

            ServicoForm sForm = new ServicoForm(_pessoa.CPF);
            sForm.ShowDialog();
            UpdateServicos(_pessoa.CPF);            
        }

        private void diasCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeServiceFromPessoa(string descricaoServico, string CPF)
        {
            try
            {
                DialogResult response = MessageBox.Show($"Deseja REMOVER este Serviço ({descricaoServico}) deste voluntário?", "Remover Serviço",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (response == DialogResult.Yes)
                {
                    RemoveFromPessoasServicos(descricaoServico, CPF);
                    // TODO make a verication above
                    // TODO atualiza listBox
                    // CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private int RemoveFromPessoasServicos(string descricaoServico, string CPF)
        {
            int resultado = -1;            
            using (SQLiteConnection conn = Repository.DbConnection())
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM Pessoas_Servicos " +
                                            "WHERE Pessoa_CPF = @CPF AND (Servico_Id) IN " +
                                                "( SELECT S.Id " +
                                                   "FROM Servicos S INNER JOIN Pessoas_Servicos " +
                                                      "ON S.Id = Pessoas_Servicos.Servico_Id " +
                                                    "WHERE (Pessoas_Servicos.Pessoa_CPF = @CPF AND S.Descricao = @Descricao))";

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@Descricao", descricaoServico);
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

        private void telefoneCelularLabel_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetEnableOnAllInputElements(true);
        }
    }

}