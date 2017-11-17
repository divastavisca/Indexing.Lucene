using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexing.LuceneIndexer
{
    public class Airline
    {
        public string Name { get; private set; }
        public string IataIdentifier { get; private set; }
        public string Description { get; private set; }

        public static List<Airline> GetSampleData()
        {
            Airline indigo = new Airline("Indigo Airlines", "IATA001", "A LCC Running domestic passenger flights in India");
            Airline spiceJet = new Airline("SpiceJet", "IATA002", "A LCC Running domestic passenger flights in India");
            Airline airIndia = new Airline("Air India", "IATA003", "A Fully operating airlines operating domestic flights in India, and International flights all over the world");
            return
                (
                    new List<Airline>()
                    {
                        indigo,
                        spiceJet,
                        airIndia
                    }
                );
        }

        public Airline(string name,string iataIdentifier,string description)
        {
            Name = name;
            IataIdentifier = iataIdentifier;
            Description = description;
        }
    }
}
