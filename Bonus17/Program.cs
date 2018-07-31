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

        public static Car CreateDefault()
        {

            return new Car();

        }

        public static Car CreateCustomPath()
        {

            int intMake = 0;
            string make = "";
            int intModel = 0;
            string model = "";
            string strYear = "0000";
            int year = 0;
            string strPrice = "";
            double price = 0.0;

            #region Make
            Console.WriteLine("Please choose a manufacturer: ");
            Console.WriteLine("1. Ford");
            Console.WriteLine("2. Dodge");
            Console.WriteLine("3. Chevy");
            Console.WriteLine("4. Honda");
            Console.WriteLine("5. Toyota");
            Console.WriteLine("6. Mercedes Benz");
            Console.WriteLine("Please enter your choice as a number.");

            do
            {

                try
                {

                    intMake = int.Parse(Console.ReadLine());

                    if (intMake > 0 && intMake < 7)
                    {

                        break;

                    }
                    else
                    {

                        Console.WriteLine($"Your entry of {intMake} is not between the numbers 1 and 6, now is it?");

                    }

                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter a N U M B E R");

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Basically, you can't choose a number 1-6");

                }

            } while (true);

            #endregion

            #region Model

            if (intMake == 1)           //Ford
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Mustang");
                Console.WriteLine("2. Focus");
                Console.WriteLine("3. Fusion");
                Console.WriteLine("4. F-150");
                Console.WriteLine("5. Thundercougarfalconbird");
                Console.WriteLine("Please enter your selection as a number.");

                do
                {

                    try
                    {

                        intModel = int.Parse(Console.ReadLine());

                        if (intModel > 0 && intModel < 6)
                        {

                            break;

                        }
                        else
                        {

                            Console.WriteLine($"Your entry of {intModel} is not between the numbers 1 and 5, now is it?");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter a N U M B E R");

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Basically, you can't choose a number 1-5");

                    }

                } while (true);

            }
            else if (intMake == 2)      //Dodge
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Challenger");
                Console.WriteLine("2. Demon");
                Console.WriteLine("3. Hellcat");
                Console.WriteLine("4. Charger");
                Console.WriteLine("5. Speedyboi");
                Console.WriteLine("Please enter your selection as a number.");

                do
                {

                    try
                    {

                        intModel = int.Parse(Console.ReadLine());

                        if (intModel > 0 && intModel < 6)
                        {

                            break;

                        }
                        else
                        {

                            Console.WriteLine($"Your entry of {intModel} is not between the numbers 1 and 5, now is it?");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter a N U M B E R");

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Basically, you can't choose a number 1-5");

                    }

                } while (true);

            }
            else if (intMake == 3)      //Chevy
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Camero");
                Console.WriteLine("2. Camera");
                Console.WriteLine("3. Levy");               //Woooooah oh Mr 'merican Pie
                Console.WriteLine("4. Wuzzdrigh");          //Took the Chevy to the levy
                Console.WriteLine("5. American3.1415");     //But the levy was dry!
                Console.WriteLine("Please enter your selection as a number.");

                do
                {

                    try
                    {

                        intModel = int.Parse(Console.ReadLine());

                        if (intModel > 0 && intModel < 6)
                        {

                            break;

                        }
                        else
                        {

                            Console.WriteLine($"Your entry of {intModel} is not between the numbers 1 and 5, now is it?");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter a N U M B E R");

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Basically, you can't choose a number 1-5");

                    }

                } while (true);

            }
            else if (intMake == 4)      //Honda
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Civic");
                Console.WriteLine("2. Accord");
                Console.WriteLine("3. The really slow van every old person has");
                Console.WriteLine("4. Oldpersonmobile");
                Console.WriteLine("5. Mach 6");             //This is a Speed Racer joke, sugoi.
                Console.WriteLine("Please enter your selection as a number.");

                do
                {

                    try
                    {

                        intModel = int.Parse(Console.ReadLine());

                        if (intModel > 0 && intModel < 6)
                        {

                            break;

                        }
                        else
                        {

                            Console.WriteLine($"Your entry of {intModel} is not between the numbers 1 and 5, now is it?");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter a N U M B E R");

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Basically, you can't choose a number 1-5");

                    }

                } while (true);

            }
            else if (intMake == 5)      //Toyota
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Prius");
                Console.WriteLine("2. Primus");     //It's like a Prius but non-divisible
                Console.WriteLine("3. Truck");
                Console.WriteLine("4. Van");
                Console.WriteLine("5. Go-Places");  //Overwatch League, sponsored by Toyota: Let's go places!
                Console.WriteLine("Please enter your selection as a number.");

                do
                {

                    try
                    {

                        intModel = int.Parse(Console.ReadLine());

                        if (intModel > 0 && intModel < 6)
                        {

                            break;

                        }
                        else
                        {

                            Console.WriteLine($"Your entry of {intModel} is not between the numbers 1 and 5, now is it?");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter a N U M B E R");

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Basically, you can't choose a number 1-5");

                    }

                } while (true);

            }
            else if (intMake == 6)      //Benz
            {

                Console.WriteLine("Please select a model from below:");
                Console.WriteLine("1. Millionairemobile");
                Console.WriteLine("2. Billionairebehicle");     //🅱ehicle
                Console.WriteLine("3. Somethingelse");
                Console.WriteLine("4. Waytoomuchmoney");
                Console.WriteLine("5. $$$$$$$$$$$$$$$");        //If you laughed at any of these, you lose.
                Console.WriteLine("Please enter your selection as a number.");

                do
                {

                    try
                    {

                        intModel = int.Parse(Console.ReadLine());

                        if (intModel > 0 && intModel < 6)
                        {

                            break;

                        }
                        else
                        {

                            Console.WriteLine($"Your entry of {intModel} is not between the numbers 1 and 5, now is it?");

                        }

                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Please enter a N U M B E R");

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Basically, you can't choose a number 1-5");

                    }

                } while (true);

            }
            else
            {

                Console.WriteLine("Here's another catch all! " + intMake);
                Console.WriteLine("Defaulting car!");
                return CreateDefault();

            }

            #endregion

            #region Year

            Console.WriteLine("What year was the car made?");

            while (!Regex.IsMatch(strYear, @"^[12]{1}[09]{1}[8901]{1}\d{1}$"))
            {

                strYear = Console.ReadLine();

                try
                {

                    year = int.Parse(strYear);

                }
                catch (Exception)
                {

                    Console.WriteLine("Catch all for now.");

                }

            }

            #endregion

            #region Price

            while (!Regex.IsMatch(strPrice, @"^\d{4,6}.\d{2}$"))
            {

                Console.WriteLine("Please input a price with 4-6 digits before the decimal place and 2 digits after.");
                strPrice = Console.ReadLine();

            }

            price = double.Parse(strPrice);

            #endregion

            string[] makes = new string[6];
            makes[0] = "Ford";
            makes[1] = "Dodge";
            makes[2] = "Chevy";
            makes[3] = "Honda";
            makes[4] = "Toyota";
            makes[5] = "Mercedes Benz";
            make = makes[intMake - 1];

            string[,] models = new string[6, 5];
            models[0, 0] = "Mustang";
            models[0, 1] = "Focus";
            models[0, 2] = "Fusion";
            models[0, 3] = "F-150";
            models[0, 4] = "Thundercougarfalconbird";

            models[1, 0] = "Challenger";
            models[1, 1] = "Demon";
            models[1, 2] = "Hellcat";
            models[1, 3] = "Charger";
            models[1, 4] = "Speedyboi";

            models[2, 0] = "Camero";
            models[2, 1] = "Camera";
            models[2, 2] = "Levy";
            models[2, 3] = "Wuzzdrigh";
            models[2, 4] = "American3.1415";

            models[3, 0] = "Civic";
            models[3, 1] = "Accord";
            models[3, 2] = "The really slow van that every old person has";
            models[3, 3] = "Oldpersonmobile";
            models[3, 4] = "Mach 6";

            models[4, 0] = "Prius";
            models[4, 1] = "Primus";
            models[4, 2] = "Truck";
            models[4, 3] = "Van";
            models[4, 4] = "Go-Places";

            models[5, 0] = "Millionairemobile";
            models[5, 1] = "Billionairebehicle";
            models[5, 2] = "Somethingelse";
            models[5, 3] = "Waytoomuchmoney";
            models[5, 4] = "$$$$$$$$$$$$$$$";

            model = models[intMake - 1, intModel - 1];

            return new Car(make, model, year, price);

        }

        public static Car CreateCustomFree()
        {

            string make = "";
            string model = "";
            int year = 0;
            double price = 0.0;



            return new Car(make, model, year, price);

        }

        static void TotalBill(List<Car> lot)
        {

            double total = 0.0;

            foreach (Car car in lot)
            {

                total += car.Price;

            }

            Console.WriteLine($"Your total so far is ${total} with {lot.Count} car(s) you're averaging {total / lot.Count}");

        }

        static bool AnothaOne()
        {

            Console.Write("Would you like to add another car? ");
            string cont = "";

            do
            {

                Console.WriteLine("(Y/N)");
                cont = Console.ReadLine();
                if (Regex.IsMatch(cont, @"[Yy]"))
                {

                    return true;

                }
                else if (Regex.IsMatch(cont, @"[Nn]"))
                {

                    return false;

                }
                else
                {

                    Console.WriteLine("You can type anything and so long as it has a Y or N in it, I'll take it.");

                }

            } while (true);

        }

        static bool Chooser(string promptTrue, string chooseTrue, string promptFalse, string chooseFalse)
        {

            Console.WriteLine($"Would you like to {promptTrue} {promptFalse}");
            string choice = "";

            do
            {

                choice = Console.ReadLine();

                if (Regex.IsMatch(choice, chooseTrue))
                {

                    Console.WriteLine("You selected " + chooseTrue);
                    return true;

                }
                else if (Regex.IsMatch(choice, chooseFalse))
                {

                    Console.WriteLine("You selected " + chooseFalse);
                    return false;

                }
                else
                {

                    Console.WriteLine($"Your answer did not contain {chooseTrue} or {chooseFalse}");
                    Console.WriteLine("Please try again.");

                }

            } while (true);

        }

        static void Main(string[] args)
        {

            List<Car> lot = new List<Car>();

            //Create better patterns for Chooser method.

            do
            {

                if (Chooser("add a custom car", "custom", "or a brand new Dodge Challenger", "dodge"))
                {

                    if (Chooser("make a car by guided prompt", "guided", "or by free entry", "free"))
                    {

                        lot.Add(CreateCustomPath());

                    }
                    else
                    {

                        lot.Add(CreateCustomFree());

                    }

                }
                else
                {

                    lot.Add(CreateDefault());

                }

                TotalBill(lot);

            } while (AnothaOne());

            Console.WriteLine("Here's your final list!");
            Console.WriteLine("============================================");
            foreach (Car car in lot)
            {

                //car.FormattedOut();
                Console.WriteLine($"{car.Year,-9} {car.Make}");
                Console.WriteLine($"${car.Price,-8} {car.Model}");
                Console.WriteLine("--------------------------------------------");

            }

            Console.WriteLine("See ya next time...");

        }

    }

}