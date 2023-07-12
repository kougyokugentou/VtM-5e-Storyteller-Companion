using Dapper;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using VtM_5e_Storyteller_Companion.Models;

namespace VtM_5e_Storyteller_Companion
{
    public class SqlDataAccess
    {
        public Clan GetClan(string name_in)
        {
            using (IDbConnection cnn = new SqlConnection())
            {
                string query = "SELECT * FROM Clan WHERE Name = @name";
                Clan output = cnn.Query<Clan>(query, new { name = name_in }).SingleOrDefault();
                return output;
            }
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["VtM5eStoryteller"].ConnectionString;
        }


    }
}
