using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsdag
{
    public class Animal : Dag1, IPerson, IAnimal
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }



        //public void create()
        //{
        //    Console.WriteLine("this is an Animal");
        //}
        public string connectionString { get; set; } = @"Server=TEC-8220-LA0025;Database=h1Tutorial001; Trusted_Connection=true; TrustServerCertificate=True ";


        public void create()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"insert into animal values('{Color}'," +
                $"'','{Firstname}','{Lastname}'," +
                $"{Age})";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public void read(int id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"select * from animal where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            // if there is only 1...
            reader.Read(); // læs 1 linje fra "table"
            Age = Convert.ToInt32(reader["age"]);
            Firstname = reader["Firstname"].ToString();
            Lastname = reader["Lastname"].ToString();
            Color = reader[1].ToString();
            //while (reader.Read()) { }
        }

        /// <summary>
        /// hvis I ønsker en liste skal returtype laves om
        /// derudover skal I returnere en liste af Animal typen
        /// denne liste skal Defineres inde i metoden.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Animal readById(int id)
        {
            //List<Animal> list = new List<Animal>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"select * from animal where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read(); // læs 1 linje fra "table"
            Age = Convert.ToInt32(reader["age"]);
            Firstname = reader["Firstname"].ToString();
            Lastname = reader["Lastname"].ToString();
            Color = reader[1].ToString();
            return this;
        }





        //override... method
        public override string ToString()
        {
            return "Id : "+Id;
        }
        public string tostring()
        {
            return this.Id+"";
        }

        public string test()
        {
            throw new NotImplementedException();
        }

        //public void create()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

namespace GPAflevering.Codes
{
    internal class Person : IComparable<Person>
    {
        public int ElevId { get; set; }
        public string? ForNavn { get; set; }
        public string? EfterNavn { get; set; }
        public int TelefonNr { get; set; }

        public int CompareTo(Person? other)
        {
            if (other != null)
                return string.Compare(ForNavn, other.EfterNavn);
            else
                return 0;
        }
    }
}
