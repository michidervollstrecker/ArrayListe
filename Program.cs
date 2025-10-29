using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace ArrayListe
{
    internal class Program
    {
        public interface IComparable
        {
            static void Main(string[] args)
            {
                Person[] pers = new Person[5];
                pers[0] = new Person() { Name = "[0] Planton", City = "München", Age = 30 };
                pers[1] = new Person() { Name = "[1] Mehmet", City = "Berlin" , Age =25 };
                pers[2] = new Person() { Name = "[2] Aladin", City = "Bremen", Age = 35 };
                pers[3] = new Person() { Name = "[3] Frank", City = "Frankfurt" , Age= 19 };
                pers[4] = new Person() { Name = "[4] Scubi", City = "Hamburg" , Age = 26 };
                ArrayList arrlist = new ArrayList(4);
                

               
                
                List<Person> pliste = new List<Person>();
                arrlist.AddRange(pers);
                

                List<int> ages = new List<int>() { 18, 20, 17, 28, 23 };
                int ai = ages.Count-1;
         
                foreach (int i in ages)
                {
                    Console.WriteLine(ages[ai]);
                    ai--;    
                }
          
                int pp = pers.Length -1;
                foreach (Person p in pers)
                {
                    Console.WriteLine(pers[pp].Name);
                    pp--;
                }
                pp = pers.Length - 1;
                    Console.WriteLine(pers[pp].Name, pers[pp].City);
                  
                

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
                Console.WriteLine("Nach dem Reverse: ");
                foreach (Person p in pliste)
                {
                    Console.WriteLine(p.Name + " " + p.City);
                }

                
                pp = pers.Length - 1;


                
                Console.WriteLine("ArrList wurde gecleart enthält jetzt Elemente:  {0} ", arrlist.Count);
                Console.WriteLine("ArrList reserviert den Speicher für Elemente {0}: " , arrlist.Capacity);
                Console.WriteLine("Pers: {0}", pers.GetLength(0));

                //Destruktor

                GC.Collect();

            }
            internal class Person
            {
                internal string Name { get; set; }
                internal string City { get; set; }
                internal int Age { get; set; }
            }
        }
    }
    }

