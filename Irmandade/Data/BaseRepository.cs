using System;
using System.Data;
using System.Data.SQLite;

namespace Irmandade.Data
{
    public class BaseRepository
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\VoluntariosDB.db"; }
        }

        public static SQLiteConnection DbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }

        public DataTable GetDataTableFromConnection<T>(string query) where T : IDbConnection, new()
        {
            using (var conn = new T())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    //cmd.Connection.ConnectionString = strings.connectionString;
                    cmd.Connection = DbConnection();
                    cmd.Connection.Open();
                    var table = new DataTable();
                    table.Load(cmd.ExecuteReader());
                    return table;
                }
            }
        }
    }
}