using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    internal class City
    {
        public string cityName { get; set; } = "";
        public string cityCode { get; set; } = "";
        public string country { get; set; } = "";
        public uint totalPop { get; set; } = 0;
        public uint womenPop { get; set; } = 0;
        public uint menPop { get; set; } = 0;

        public City() { }
        public City(string cityName, string cityCode, string country, uint totalPop, uint womenPop, uint menPop)
        {
            this.cityName = cityName;
            this.cityCode = cityCode;
            this.country = country;
            this.totalPop = totalPop;
            this.womenPop = womenPop;
            this.menPop = menPop;
        }
        public City(string cityName)
        {
            this.cityName = cityName;
        }
    }
}
