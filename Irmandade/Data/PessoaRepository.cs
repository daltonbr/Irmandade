using System.IO;
using System.Linq;
using Dapper;
using Irmandade.Model;

namespace Irmandade.Data
{
    public class PessoaRepository : BaseRepository
    {
        public Pessoa GetPessoa(string CPF)
        {
            if (!File.Exists(DbFile)) return null;

            using (var conn = DbConnection())
            {
                conn.Open();
                Pessoa result = conn.Query<Pessoa>(
                    @"SELECT *
                    FROM Pessoas
                    WHERE CPF = @CPF", new { CPF }).FirstOrDefault();
                return result;
            }
        }

        public void SavePessoa(Pessoa pessoa)
        {
            if (!File.Exists(DbFile))
            {
                CreateDatabase();
            }

            using (var conn = DbConnection())
            {
                conn.Open();
                pessoa.CPF = conn.Query<string>(
                    @"INSERT INTO Pessoas(CPF, RG, RGEmissor, Nome, Endereco, TelefoneFixo, TelefoneCelular, InicioDasAtividades, Observacoes, Email, DisponivelSegunda, DisponivelTerca, DisponivelQuarta, DisponivelQuinta, DisponivelSexta) " +
                                       "VALUES (@CPF, @RG, @RGEmissor, @Nome, @Endereco, @TelefoneFixo, @TelefoneCelular, @InicioDasAtividades, @Observacoes, @Email, @DisponivelSegunda, @DisponivelTerca, @DisponivelQuarta, @DisponivelQuinta, @DisponivelSexta)", pessoa).First();                
            }

            
        }

        private static void CreateDatabase()
        {
            using (var conn = DbConnection())
            {
                conn.Open();
                conn.Execute(
                    @"CREATE TABLE ""Pessoas"" ( `CPF` TEXT NOT NULL, `RG` TEXT, `RGEmissor` TEXT, `Nome` TEXT NOT NULL, `Endereco` TEXT, `TelefoneFixo` TEXT, `TelefoneCelular` TEXT, `InicioDasAtividades` TEXT NOT NULL, `Observacoes` TEXT, `Email` TEXT, `DisponivelSegunda` INTEGER NOT NULL DEFAULT 0, `DisponivelTerca` INTEGER NOT NULL DEFAULT 0, `DisponivelQuarta` INTEGER NOT NULL DEFAULT 0, `DisponivelQuinta` INTEGER NOT NULL DEFAULT 0, `DisponivelSexta` INTEGER NOT NULL DEFAULT 0, CONSTRAINT `PK_Pessoas` PRIMARY KEY(`CPF`) )");
                conn.Execute(
                    @"CREATE TABLE ""Servicos""( `Id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Descricao` TEXT NOT NULL)");
                conn.Execute(
                    @"CREATE TABLE ""Pessoas_Servicos""( `Servico_Id` INTEGER, `Pessoa_CPF` TEXT, PRIMARY KEY(`Servico_Id`,`Pessoa_CPF`), FOREIGN KEY(`Pessoa_CPF`) REFERENCES `Pessoas`(`CPF`), FOREIGN KEY(`Servico_Id`) REFERENCES `Servicos`(`Id`) )");
                conn.Close();
            }
        }
    }
}