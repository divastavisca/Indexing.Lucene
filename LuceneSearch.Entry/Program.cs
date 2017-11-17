using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indexing.LuceneIndexer;

namespace LuceneSearch.Entry
{
    class Program
    {
        public static void Main(string[] args)
        {
            List < Airline > airlineList = Airline.GetSampleData();
            CustomLuceneSearch.AddUpdateLuceneIndex(airlineList);
            while (true)
            {
                Console.WriteLine("Enter your search query...");
                string querry = Console.ReadLine();
                IEnumerable<Airline> airlineResults = CustomLuceneSearch.Search(querry);
                if (airlineResults.Count<Airline>() > 0)
                {
                    Console.WriteLine($"{airlineResults.Count<Airline>()} Record(s) Found\n");
                    int i = 1;
                    foreach (Airline airline in airlineResults)
                    {
                        Console.WriteLine($"Record ({i++})\n");
                        Console.WriteLine($"Name : {airline.Name}\nIata Identification : {airline.IataIdentifier}\nDescription : {airline.Description}");
                    }
                }
                else Console.WriteLine("No such record found");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
