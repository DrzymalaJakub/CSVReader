using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    internal class CSVReader
    {
        private string? filePath;
        public CSVReader() { }
        public CSVReader(string? filePath)
        {
            this.filePath = filePath;
        }

        public City[]? ReadFirstNCities(uint nCities)
        {
            City[] cities = new City[nCities];
            return cities;
        }

        public City ReadCityFromCSVLine(string line)
        {
            string[] parts = line.Split(',');
            string cityName = parts[0];

            return new City(cityName);
        }
    }
}
