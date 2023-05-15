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
        public void create()
        {
            Console.WriteLine("this is an Animal");
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
