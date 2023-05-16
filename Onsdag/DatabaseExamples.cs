using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsdag
{
    public class DatabaseExamples
    {
        private string connectionString { get; set; } = @"Server=TEC-8220-LA0025;Database=h1Tutorial001; Trusted_Connection=true; TrustServerCertificate=True";
        public void CreateCommand(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
