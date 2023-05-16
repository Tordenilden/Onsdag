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
