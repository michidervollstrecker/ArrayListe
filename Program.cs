using System.Collections;
using System.Collections.Generic;
namespace ArrayListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] pers = new Person[4];
            pers[0] = new Person() { Name = "[0] Anton" };
            pers[1] = new Person() { Name = "[1] Mehmet"};
            pers[2] = new Person() { Name = "[2] Aladin" };
            pers[3] = new Person() { Name = "[3] Frank" };
          
            ArrayList arrlist = new ArrayList();
            arrlist.AddRange(pers);
            List<Person> pliste = new List<Person>();
            pliste.AddRange(pers);
            Console.WriteLine("PListe enthält :\n{0}", pliste.Count);
            Console.WriteLine("HashCode der Pliste ist:\n{0}", pliste.GetHashCode());
            Console.WriteLine("ArrayList kann {0} Personen aufnehmen. ", arrlist.Capacity);
            Console.WriteLine("ArrayList enthält {0} Personen", arrlist.Count);
            foreach (Person p in arrlist)
            {
                Console.WriteLine(p.Name + " " + p.City);
            }
            arrlist.Reverse();
            Console.WriteLine("HashCode der ArrayListe \n :{0}", arrlist.GetHashCode());
            Console.WriteLine("Nach dem Reverse:\n");
            foreach (Person p in arrlist)
            {
                Console.WriteLine(p.Name + " " + p.City);
            }
            Console.WriteLine("Jetzt wird sortiert und nochmal ausgegeben:");
            arrlist.Sort();
            Console.WriteLine(pliste.sort()
            

        }
        internal class Person {
            public string Name { get; set; }
            public string City { get; set; }
        }
    }
}
