using System.IO;
using System.Linq;
using Dapper;
using Irmandade.Model;
using System.Data;
using System.Data.SQLite;

namespace Irmandade.Data
{
    public class ServicoRepository : BaseRepository
    {
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
        
    }
}