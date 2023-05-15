// See https://aka.ms/new-console-template for more information

namespace Onsdag
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region onsdag
            // person1 is an object
            Person person1 = new Person(); // instantiate
            // objectName.ThePropertyYouWant
            person1.Name = "Bo the great Dane";
            person1.Age = 123;

            //Invoke // call a method
            person1.hat();

            //declaration / definition
            int tal = 99;
            #endregion onsdag

            IPerson person2 = new Person();
            IPerson person3 = new Animal();

            List<IPerson> list = new List<IPerson>();
            list.Add(person2);
            list.Add(person3);

            // foreach(Type variabelObj in CollectionName)
            foreach(IPerson person in list)
            {
                person.create();
            }








            //Initializer
            List<Animal> animalList = new List<Animal>()
            {
                new Animal(){ Id=1, Age=5, Color="red", Name="Hansi"},
                new Animal(){ Id=2, Age=15, Color="blue", Name="Bo"},
                new Animal(){ Id=3, Age=25, Color="yellow", Name="Søren"},
                new Animal(){ Id=4, Age=95, Color="red", Name="Søren"},
            };

            // LINQ (Language Integrated Query) - SQL
            // FirstOrDefault()
            // Where()
            // Max()
            // Count()
            // if you have to much time... Select(new //anonymous), Include()

            //Collection.LINQ_Method(()=>if sætning)

            var temp = animalList.
                FirstOrDefault<Animal>((kaffe) => kaffe.Id == 1);
            var temp1 = animalList.
                FirstOrDefault<Animal>((kaffe) => kaffe.Id == 4);
            var temp3 = animalList.
                FirstOrDefault<Animal>(
                (kaffe) => 
                (kaffe.Id == 3 || kaffe.Name == "Bo")
                );
            var temp2List = animalList.Where(
                (katte)=>
                (katte.Id==3 || katte.Name=="Hansi")
                );
            var temp4 = animalList.Max((katte) => katte.Id);

            Animal aa = new Animal();
            aa.Id = 1;
            Console.WriteLine(aa.ToString());
            string ss = aa.ToString();

            // result to console...
            // 1) 1 object, just c.w(temp.age) //ex
            // 2) list<objects> , foreach ....

            // if Error.... typecast something
            string s = "123";
            //int sum1 = s; //Convert.ToInt32(s);
            //string a = ((Animal)temp1).Name;
            //Animal a1 = temp1;
            //List<Animal> animalList = new List<Animal>()
            //{
            //    new Animal(){ Id=1, Age=5, Color="red", Name="Hansi"},
            //    new Animal(){ Id=2, Age=15, Color="blue", Name="Bo"},
            //    new Animal(){ Id=3, Age=25, Color="yellow", Name="Søren"},
            //    new Animal(){ Id=4, Age=95, Color="red", Name="Søren"},
            //};
            int tall = 77;













        }
    }
    /// <summary>
    /// Blueprint // skabelon
    /// Definition of a type
    /// </summary>
    public class Person : IPerson // Type
    {
        public string Name { get; set; } = ""; //property
        public int Age { get; set; }

        public void hat() // method
        {
            Console.WriteLine("this is a test");
        }

        public void create()
        {
            Console.WriteLine("Iam a Person");
        }


        //constructor 
        //

        public Person()
        {
            Console.WriteLine("This is called everytime an object is instantiated");
        }
    }
}
