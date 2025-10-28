using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ArrayListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] pers = new Person[4];
            pers[0] = new Person() { Name = "[0] Anton" , City = "München" };
            pers[1] = new Person() { Name = "[1] Mehmet" , City = "Berlin"};
            pers[2] = new Person() { Name = "[2] Aladin" , City = "Bremen" };
            pers[3] = new Person() { Name = "[3] Frank" , City = "Frankfurt" };
            ArrayList arrlist1 = new ArrayList();
            
        
            
            
          


            ArrayList arrlist = new ArrayList();
        
            List<Person> pliste = new List<Person>();
            
           

            pliste.AddRange(pers);
            Console.WriteLine("PListe enthält :\n{0}", pliste.Count);
            Console.WriteLine("HashCode der Pliste ist:\n{0}\n", pliste.GetHashCode());
            Console.WriteLine("ArrayList kann {0} Personen aufnehmen. ", arrlist.Capacity);
            Console.WriteLine("ArrayList enthält {0} Personen\n", arrlist.Count);
            foreach (Person p in arrlist)
            {
                Console.WriteLine(p.Name + " " + p.City);
            }
            arrlist.Reverse();
            Console.WriteLine("HashCode der ArrayListe: \n {0}\n", arrlist.GetHashCode());
            Console.WriteLine("Nach dem Reverse ");
            foreach (Person p in arrlist)
            {
                Console.WriteLine(p.Name + " " + p.City);
            }
            arrlist.Clear();
            Console.WriteLine("ArrList wurde gecleart enthält jetzt Elemente:  {0} ", arrlist.Count);
            Console.WriteLine("ArrList reserviert den Speicher für Elemente: " + arrlist.Capacity );
        
        }
        internal class Person {
            internal string Name { get; set; }
            internal string City { get; set; }
        }
    }
}
