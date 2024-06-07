using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPP
{
    internal class Biler
    {
        private string Brand;
        private int Year;
        private string RegisterNum;
        private int Km;

        public Biler(string brand, int year, string registerNum, int km)
        {
            Brand = brand;
            Year = year;
            RegisterNum = registerNum;
            Km = km;
        }

        public string GetBrand()
        {
            return Brand;
        }

        public int GetYear()
        {
            return Year;
        }   

        public string GetRegisterNum()
        {
            return RegisterNum;
        }
        public int GetKm() 
        {
            return Km; 
        }

        public string InfoString()
        {
            var info = $"Merke: {Brand}, Årsgang: {Year}, Registeringsnummer: {RegisterNum}, Kilometerstand: {Km}";
            return info;
        }
    }

}
