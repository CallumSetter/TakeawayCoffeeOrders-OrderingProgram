//Imports
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace TakeawayCoffeeOrders_OrderingProgram
{
    class Program
    {
        //Global Variables
        static List<string> waitingList = new List<string>();

        static void Main()
        {

            //Make sure the user can only order a takeaway coffee

            //A takeaway coffee is demanded by the user

            Console.WriteLine("Hello, what type type of coffee would like to order\n\n" +
                "---------- Menu ----------\n" +
                "For a Flat White Press 1\n" +
                "For a Latte Press 2\n" +
                "For a Chai Latte Press 3\n" +
                "For a Short Black Press 4\n" +
                "For a Long Black Press 5\n" +
                "For a Cappuccino Press 6\n" +
                "For a Mocha Press 7\n" +
                "--------------------------\n");
            
            
                bool ordering = true;
                string userInput;
                double itemPrice;
                double itemQuantity;
                double subTol;
                string response;

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("You have selected a Flat White\n" +
                            "What size would you like: " +
                            "\n-----------------------------------------------------" +
                            "\nSmall will cost $4.50 - Press 1 for this option\n     " +
                            "\nMedium will cost $5.00 - Press 2 for this option\n   " +
                            "\nLarge will cost $5.50 - Press 3 for this option\n   " +
                            "\nExtra Large will cost $6.00 - Press 4 for this option" +
                            "\n-----------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "2":

                        Console.WriteLine("You have selected a Latte\n" +
                            "What size would you like: " +
                            "\n-------------------------------------------------------" +
                            "\nSmall will cost $4.30 - Press 1 for this option\n" +
                            "\nMedium will cost $4.60 - Press 2 for this option\n" +
                            "\nLarge will cost $4.90 - Press 3 for this option\n" +
                            "\nExtra Large will cost $5.20 - Press 4 for this option" +
                            "\n-------------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "3":

                        Console.WriteLine("You have selected a Chai Latte\n" +
                            "What size would you like: " +
                            "\n-----------------------------------------------------" +
                            "\nSmall will cost $5.00 - Press 1 for this option\n   " +
                            "\nMedium will cost $5.70 - Press 2 for this option\n   " +
                            "\nLarge will cost $6.50 - Press 3 for this option\n  " +
                            "\nExtra Large will cost $7.20 - Press 4 for this option" +
                            "\n-----------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "4":

                        Console.WriteLine("You have selceted a Short Black\n" +
                            "What size would you like:" +
                            "\n------------------------------------------------------" +
                            "\nSmall will cost $4.00 - Press 1 for this option\n" +
                            "\nMedium will cost $4.40 - Press 2 for this option\n" +
                            "\nLarge will cost $4.80 - Press 3 for this option\n" +
                            "\nExtra Large will cost $5.20 - Press 4 for this option" +
                            "\n------------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "5":

                        Console.WriteLine("You have selceted a Long Black\n" +
                            "What size would you like:" +
                            "\n-----------------------------------------------------" +
                            "\nSmall will cost $5.00 - Press 1 for this option\n" +
                            "\nMedium will cost $5.20 - Press 2 for this option\n" +
                            "\nLarge will cost $5.40 - Press 3 for this option\n" +
                            "\nExtra Large will cost $5.60 - Press 4 for this option" +
                            "\n-----------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "6":

                        Console.WriteLine("You have selceted a Cappuccino\n" +
                            "What size would you like:" +
                            "\n-----------------------------------------------------" +
                            "\nSmall will cost $5.50 - Press 1 for this option\n" +
                            "\nMedium will cost $6.00 - Press 2 for this option\n" +
                            "\nLarge will cost $6.50 - Press 3 for this option\n" +
                            "\nExtra Large will cost $7.00 - Press 4 for this option" +
                            "\n-----------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "7":

                        Console.WriteLine("You have selceted a Mocha\n" +
                            "What size would you like:" +
                            "\n-----------------------------------------------------" +
                            "\nSmall will cost $5.40 - Press 1 for this option\n" +
                            "\nMedium will cost $5.80 - Press 2 for this option\n" +
                            "\nLarge will cost $6.20 - Press 3 for this option\n" +
                            "\nExtra Large will cost $6.60 - Press 4 for this option" +
                            "\n-----------------------------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    default:
                        Console.WriteLine("Sorry, that option is not on our menu.");
                        break;

                }
            
            Console.ReadLine();
            Console.WriteLine("Your coffee is now being prepared!");
            Console.WriteLine("Expected waiting time: 5 seconds\n");



            Thread.Sleep(900);
            Console.WriteLine("Measuring the brew ratio");


            Thread.Sleep(900);
            Console.WriteLine("Grinding the coffee beans");

            Thread.Sleep(900);
            Console.WriteLine("Boiling the water");

            Thread.Sleep(900);
            Console.WriteLine("Placing coffee into the filter");

            Thread.Sleep(900);
            Console.WriteLine("Pouring the coffee");

            Thread.Sleep(900);
            Console.WriteLine("\nYour coffee is now ready!\n" +
                "Would you like your receipt" +
                "\nYes - Press y" +
                "\nNo - Press n");


























        }



    }
}


