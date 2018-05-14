﻿using Dapper;
using Irmandade.Model;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Irmandade.Data
{
    /// <summary>
    /// Singleton Class used to access the database
    /// </summary>
    public class Repository
    {
        private static Repository _instance;

        private Repository() { }

        /// <summary>
        /// Singleton Pattern Constructor
        /// </summary>
        public static Repository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Repository();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Returns the complete path to the SQLite database
        /// </summary>
        public static string DbFile
        {
            // The file name is written in the resource file
            get { return Environment.CurrentDirectory + "\\" + strings.databaseFileName; }
        }

        public static SQLiteConnection DbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile + ";foreign keys = true;");
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
                    try
                    {
                        table.Load(cmd.ExecuteReader());
                    }
                    catch(SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
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
                        InicioDasAtividades TEXT,
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
                        Descricao TEXT NOT NULL UNIQUE
                )");
                conn.Execute(
                    @"CREATE TABLE Pessoas_Servicos (
                        Servico_Id INTEGER,
                        Pessoa_CPF TEXT,
                        PRIMARY KEY(Servico_Id,Pessoa_CPF),
                        FOREIGN KEY(Pessoa_CPF) REFERENCES Pessoas(CPF) ON DELETE CASCADE ON UPDATE CASCADE, 
                        FOREIGN KEY(Servico_Id) REFERENCES Servicos(Id) ON DELETE CASCADE
                )");
                conn.Close();
            }
            MessageBox.Show("Um novo banco de dados foi criado!");
        }

        #region Pessoa table
        public Pessoa GetPessoaByCPF(string CPF)
        {
            if (!File.Exists(DbFile)) return null;

            using (SQLiteConnection conn = DbConnection())
            {
                conn.Open();
                Pessoa result = conn.Query<Pessoa>(
                    @"SELECT *
                    FROM Pessoas
                    WHERE CPF = @CPF", new { CPF }).FirstOrDefault();
                return result;
            }
        }

        public DataTable GetPessoasByNome(string nome)
        {
            string sql = "SELECT * FROM Pessoas WHERE Nome LIKE '%" + nome + "%'";

            return this.GetDataTableFromConnection<SQLiteConnection>(sql);            
        }

        public DataTable GetPessoasByDiasDisponiveis(bool segunda,
                                                     bool terca,
                                                     bool quarta,
                                                     bool quinta,
                                                     bool sexta)
        {
            // Concatenates the SQL Query suffix
            string[] sqlSuffixList = new string[]
            {
                segunda ? "DisponivelSegunda = 1" : null,
                terca   ? "DisponivelTerca = 1" : null,
                quarta  ? "DisponivelQuarta = 1" : null,
                quinta  ? "DisponivelQuinta = 1" : null,
                sexta   ? "DisponivelSexta = 1" : null
            };
            string sqlSuffix = string.Join(" AND ", sqlSuffixList.Where(x => x != null));
            bool isEmpty = sqlSuffixList.All(x => x == null);

            if (isEmpty)
            {
                sqlSuffix = "";
            }
            else
            {
                sqlSuffix = "WHERE " + sqlSuffix;
            }

            string sql = "SELECT * FROM Pessoas " + sqlSuffix;

            return this.GetDataTableFromConnection<SQLiteConnection>(sql);            
        }

        public DataTable GetPessoasByNomeServicoDiasDisponiveis(string nome, string servico, bool[] diasDisponiveis)
        {
            // Concatenates the SQL Query suffix
            string[] sqlSuffixList = new string[]
            {
                diasDisponiveis[0] ? "DisponivelSegunda = 1" : null,
                diasDisponiveis[1] ? "DisponivelTerca = 1" : null,
                diasDisponiveis[2] ? "DisponivelQuarta = 1" : null,
                diasDisponiveis[3] ? "DisponivelQuinta = 1" : null,
                diasDisponiveis[4] ? "DisponivelSexta = 1" : null
            };
            string sqlDias = string.Join(" AND ", sqlSuffixList.Where(x => x != null));
            bool isEmpty = sqlSuffixList.All(x => x == null);

            if (isEmpty)
            {
                sqlDias = "";
            }
            else
            {
                sqlDias = " AND " + sqlDias;
            }

            string sqlServicoJoin = "";
            if (string.IsNullOrEmpty(servico))            
            {
                sqlServicoJoin = " WHERE ";
            }
            else
            {
                sqlServicoJoin = @" INNER JOIN Pessoas_Servicos PS
                                        ON (P.CPF = PS.Pessoa_CPF)
                                    INNER JOIN Servicos S
                                        ON (PS.Servico_Id = S.Id)
                                    WHERE S.Descricao = " + @" """ + servico + @""" AND ";
            }
            string fields = "P.CPF, P.Nome, P.Email, P.TelefoneFixo, P.TelefoneCelular";
            string finalSql = "SELECT "+ fields + " FROM Pessoas P " + sqlServicoJoin + " Nome LIKE '%" + nome + "%'" + sqlDias ;
            return this.GetDataTableFromConnection<SQLiteConnection>(finalSql);
        }

        public void SavePessoa(Pessoa pessoa)
        {
            if (!File.Exists(DbFile))
            {
                CreateDatabase();
            }

            using (SQLiteConnection conn = DbConnection())
            {
                conn.Open();
                pessoa.CPF = conn.Query<string>(
                    @"INSERT INTO Pessoas(CPF, RG, RGEmissor, Nome, Endereco, TelefoneFixo, TelefoneCelular,
                                          InicioDasAtividades, Observacoes, Email, DisponivelSegunda, DisponivelTerca,
                                          DisponivelQuarta, DisponivelQuinta, DisponivelSexta) " +
                    "VALUES (@CPF, @RG, @RGEmissor, @Nome, @Endereco, @TelefoneFixo, @TelefoneCelular, @InicioDasAtividades, " +
                            "@Observacoes, @Email, @DisponivelSegunda, @DisponivelTerca, @DisponivelQuarta, @DisponivelQuinta, " +
                            "@DisponivelSexta)", pessoa).First();
            }
        }

        #endregion

        #region Servicos Table

        public Servico GetServico(int Id)
        {
            if (!File.Exists(DbFile)) return null;

            using (var conn = DbConnection())
            {
                conn.Open();
                Servico result = conn.Query<Servico>(
                    @"SELECT *
                    FROM Servicos
                    WHERE Id = @Id", new { Id }).FirstOrDefault();
                return result;
            }
        }

        public void SaveServico(Servico servico)
        {
            if (!File.Exists(DbFile))
            {
                CreateDatabase();
            }

            using (var conn = DbConnection())
            {
                conn.Open();
                servico.Id = conn.Query<int>(
                    @"INSERT INTO Servicos(Id, Descricao) " +
                        "VALUES (@Id, @Descricao)", servico).First();
            }
        }

        public DataTable ProcurarServico(string descricao)
        {
            string sql = "SELECT * FROM Servicos WHERE Descricao LIKE '%" + descricao + "%'";
            using (var conn = DbConnection())
            {
                conn.Open();
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
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
        }

        #endregion

        public int EditServico(string oldDescricao, string newDescricao)
        {
            int resultado = -1;

            using (SQLiteConnection conn = Repository.DbConnection())
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE Servicos " + 
                                      "SET Descricao = @newDescricao " +
                                      "WHERE Descricao = @oldDescricao";
                    cmd.Prepare();                    
                    cmd.Parameters.AddWithValue("@newDescricao", newDescricao);
                    cmd.Parameters.AddWithValue("@oldDescricao", oldDescricao);
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