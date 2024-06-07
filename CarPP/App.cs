using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPP
{
    internal class App
    {
        List<Biler> cars = new()
        {
            new("BMW", 2015, "BN12345", 13587),
            new("Mercedes", 2007, "NB63546", 230000),
            new("Porche", 2018, "TV76498", 143000),
            new("Ford", 2012, "FD23456", 75000),
            new("Toyota", 2019, "TY78901", 22000),
            new("Honda", 2018, "HN45678", 35000),
            new("Chevrolet", 2016, "CV13579", 50000),
            new("Volkswagen", 2014, "VW98765", 80000),
            new("Audi", 2017, "AD24680", 40000),
            new("Nissan", 2013, "NS35791", 65000),
            new("Hyundai", 2020, "HY24680", 15000),
            new("Subaru", 2011, "SB12345", 90000),
            new("Kia", 2015, "KA54321", 60000),
            new("BMW", 2010, "BM98765", 100000),
            new("Mercedes", 2016, "MD65432", 55000),
            new("Ford", 2018, "FD54321", 30000),
            new("Toyota", 2015, "TY23456", 70000),
            new("Honda", 2019, "HN78901", 25000),
            new("Chevrolet", 2014, "CV67890", 85000),
            new("Volkswagen", 2017, "VW45678", 45000),
            new("Audi", 2016, "AD98765", 60000),
            new("Nissan", 2012, "NS65432", 95000),
            new("Hyundai", 2018, "HY78901", 40000)
        };

        public void Run()
        {

            StartUp();
        }

        public void StartUp()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til bilbuttiken!");
            Console.WriteLine("Hva kan vi hjelpe deg med?\n");
            Console.WriteLine("1. Søk biler etter år.");
            Console.WriteLine("2. Vis biler etter km.");
            Console.WriteLine("3. Vis biler etter merke.");
            Console.WriteLine("4. Vis alle bilene.");

            var userInput = Console.ReadLine();
            int userInputNum = Convert.ToInt32(userInput);

            switch (userInputNum) 
            {
                case 1:
                    showYears();
                    break;

                case 2:
                    showKm();
                    break;

                case 3:
                    showBrands();
                    break;

                case 4:
                    showCars();
                    break;
            }
        }

        public void SortByKm()
        {
            Console.WriteLine("Skriv inn ønsket kilometerstand:");
            var userKmInput = Console.ReadLine();
            int userKmInputNum = Convert.ToInt32(userKmInput);

            Console.Clear();
            Console.WriteLine($"Vil du se mindre enn eller mer enn {userKmInput}?");
            Console.WriteLine("1. Større enn.");
            Console.WriteLine("2. Mindre enn.");

            var userInput2 = Console.ReadLine();

            if (userInput2 == "1")
            {
                foreach (var car in cars)
                {
                    if(car.GetKm() > userKmInputNum)
                    {
                        Console.WriteLine(car.InfoString());
                    }
                }
            }
            else if (userInput2 == "2")
            {
                foreach (var car in cars)
                {
                    if (car.GetKm() < userKmInputNum)
                    {
                        Console.WriteLine(car.InfoString());
                    }
                }
            }
        }

        public void ShowCarsByYear(int year) 
        {

            var noHits = true;
            foreach (var car in cars) 
            {
                
                if (year == car.GetYear()) 
                {
                    
                    Console.WriteLine($"\n{car.InfoString()}");
                    noHits = false;
                } 
            }
            if (noHits == true)
            {
                Console.WriteLine("There are no cars matching this year");
            }
        }

        public void chooseYear() 
        {  
            Console.WriteLine("Search car year:");
            var year = Convert.ToInt32(Console.ReadLine()); 
            ShowCarsByYear(year);
        }

        public void showCarsByBrand(string brand) 
        {
            foreach (var car in cars)
            {
                if (brand == car.GetBrand())
                {
                    Console.WriteLine($"\n{car.InfoString()}");
                }
            }
        }

        public void SortByBrand()
        {
            List<string> brands = new List<string>();
            foreach (var car in cars)
            {
                if (!brands.Contains(car.GetBrand()))
                {
                    brands.Add(car.GetBrand());
                }
            }
            Console.WriteLine("\nHvilket bilmerke vil du se?\n");
            for (int i = 0; i < brands.Count; i++)
            {
                Console.WriteLine($"{i}. {brands[i]}");
            }
            var userInput = Console.ReadLine();
            int userInputNum = Convert.ToInt32(userInput);

            showCarsByBrand(brands[userInputNum]);
        }


        public void showAllCars() 
        {
            foreach(var car in cars) 
            { 
                Console.WriteLine(car.InfoString());
            }
        }

        public void showCars() 
        {
            Console.Clear();
            showAllCars();
            ReturnToStart();
        }

        public void showKm() 
        {
            Console.Clear();
            SortByKm();
            ReturnToStart();
        }

        public void showBrands() 
        {
            Console.Clear();
            SortByBrand();
            ReturnToStart();
        }
        

        public void showYears() 
        {
            Console.Clear();
            chooseYear();
            ReturnToStart();
        }
        public void ReturnToStart()
        {
            Console.WriteLine("Trykk en tast for å gå tilbake...");
            Console.ReadKey();
            StartUp();
        }
    }
}
