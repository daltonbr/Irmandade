using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Irmandade.Data
{
    public class BaseRepository
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\" + strings.databaseFileName; }
        }

        public static SQLiteConnection DbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }

        public DataTable GetDataTableFromConnection<T>(string query) where T : IDbConnection, new()
        {
            if (!File.Exists(DbFile))
            {
                CreateDatabase();
            }

            using (var conn = new T())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;                    
                    cmd.Connection = DbConnection();
                    cmd.Connection.Open();
                    var table = new DataTable();
                    table.Load(cmd.ExecuteReader());
                    return table;
                }
            }
        }

        protected static void CreateDatabase()
        {
            using (var conn = DbConnection())
            {
                conn.Open();

                conn.Execute(
                    @"CREATE TABLE IF NOT EXISTS Pessoas (
                        CPF TEXT NOT NULL,
                        RG TEXT,
                        RGEmissor TEXT,
                        Nome TEXT NOT NULL,
                        Endereco TEXT,
                        TelefoneFixo TEXT,
                        TelefoneCelular TEXT,
                        InicioDasAtividades TEXT NOT NULL,
                        Observacoes TEXT,
                        Email TEXT,
                        DisponivelSegunda INTEGER NOT NULL DEFAULT 0,
                        DisponivelTerca INTEGER NOT NULL DEFAULT 0,
                        DisponivelQuarta INTEGER NOT NULL DEFAULT 0,
                        DisponivelQuinta INTEGER NOT NULL DEFAULT 0,
                        DisponivelSexta INTEGER NOT NULL DEFAULT 0,
                        CONSTRAINT PK_Pessoas PRIMARY KEY(CPF) 
                )");
                conn.Execute(
                    @"CREATE TABLE IF NOT EXISTS Servicos (
                        Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        Descricao TEXT NOT NULL
                )");
                conn.Execute(
                    @"CREATE TABLE Pessoas_Servicos (
                        Servico_Id INTEGER,
                        Pessoa_CPF TEXT,
                        PRIMARY KEY(Servico_Id,Pessoa_CPF),
                        FOREIGN KEY(Pessoa_CPF) REFERENCES Pessoas(CPF),
                        FOREIGN KEY(Servico_Id) REFERENCES Servicos(Id)
                )");
                conn.Close();
            }
        }
    }
}