using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bonus17
{

    class Program
    {

        public static void ListStock(List<Car> inv)
        {

            Console.WriteLine($"Our current inventory contains {inv.Count} car(s).");
            Console.WriteLine("Here are our cars:");

            int counter = 1;
            foreach (Car car in inv)
            {

                Console.WriteLine(counter + ". " + car.ToString());
                counter++;

            }

        }

        static int Chooser(List<Car> stock)
        {

            Byte choice = 100;

            while (choice > stock.Count)
            {

                try
                {

                    choice = Byte.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {

                    Console.WriteLine("Invalid entry! " + e.Message);

                }

            }

            choice--;
            return choice;

        }

        static bool Buy(string prompt)
        {

            string choice = "";

            while (true)
            {

                Console.WriteLine(prompt + " (Y/N)");
                choice = Console.ReadLine();

                try
                {

                    if(Regex.IsMatch(choice, @"[yY]"))
                    {

                        return true;

                    }
                    else if (Regex.IsMatch(choice, @"[Nn]"))
                    {

                        return false;

                    }
                    else
                    {

                        Console.WriteLine("Whoops! " + choice);

                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine("Invalid entry! " + e.Message);

                }

            }

        }

        static void Main(string[] args)
        {

            List<Car> stock = new List<Car>();
            stock.Add(new Car());
            stock.Add(new UsedCar());
            stock.Add(new UsedCar(new Car(), 2000));
            stock.Add(new Car("Ford", "Fusion", 2010, 20000));
            stock.Add(new UsedCar(stock[3], 15000));
            stock.Add(new Car("Chevy", "Camero", 2016, 24000));

            do
            {

                ListStock(stock);

                Console.WriteLine("Enter the number of a car you'd like to know more about.");

                do
                {

                    int car = Chooser(stock);
                    var temp = stock[car];

                    Console.WriteLine(temp.ToString());

                    if(Buy("Buy this car?"))
                    {

                        stock.Remove(stock[car]);

                    }

                } while (false);

            } while (Buy("Anotha one?"));

            Console.WriteLine("See ya next time...");

        }

    }

}