using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Onsdag
{
    public class Database // Type
    {
        //TEC-8220-LA0025
        public string connectionString { get; set; } = @"Server=TEC-8220-LA0025;Database=h1Tutorial001; Trusted_Connection=true; TrustServerCertificate=True ";

        // insert into tablename (columnnames) values();
        // insert into tablename values();
        // a programming Language consists of 4 subjects:
        // 1) methods
        // 2) variables
        // 3) a soul
        // 4) types - you cant have 2 types after each other

        /// <summary>
        /// This method is hardcoded
        /// 1) Now I want to pass data to it, so it can variate....
        /// 2) How do I do it??
        /// 3) at least 2 ways to do that
        /// </summary>
        public void createHardcoded()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "insert into animal values('purple','','Bo','Hanson',44)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            // we wait a few minutes....
            // 

        }
        /// <summary>
        /// Normal create.....
        /// 1) only ANimal => pass in ANimal object
        /// 2) Animal, Employee, Person => IPerson, Inheritance, object
        /// </summary>
        /// <param name="justSoItWorks"></param>
        public void create(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
