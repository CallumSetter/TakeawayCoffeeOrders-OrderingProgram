//Imports
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;


namespace TakeawayCoffeeOrders_OrderingProgram
{
    class Program
    {
        //Global Variables
        static List<string> waitingList = new List<string>();
        

        
       

        static string OneCoffee()
        {

            //Make sure the user can only order a takeaway coffee
            //A takeaway coffee is demanded by the user
            Console.WriteLine(
                    "-------- Menu --------\n" +
                    "Flat White   - Press 1\n" +
                    "Latte        - Press 2\n" +
                    "Chai Latte   - Press 3\n" +
                    "Short Black  - Press 4\n" +
                    "Long Black   - Press 5\n" +
                    "Cappuccino   - Press 6\n" +
                    "Mocha        - Press 7\n" +
                    "Americano    - Press 8\n" +
                    "----------------------\n" +
                    "More - Press 9\n");

            
            while (true)
            {

                //Make sure the user pays the right amount of money for their coffee


                string userInput;
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":

                        Console.WriteLine("You have selected a Flat White\n" +
                            "Select Size: " +
                            "\n------------------------------" +
                            "\nSmall: $4.50         - Press 1\n" +
                            "\nMedium: $5.00        - Press 2\n" +
                            "\nLarge: $5.50         - Press 3\n" +
                            "\nExtra Large: $5.50   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");



                        break;
                    case "2":

                        Console.WriteLine("You have selected a Latte\n" +
                            "Select Size: " +
                            "\n------------------------------" +
                            "\nSmall:  $4.30        - Press 1\n" +
                            "\nMedium: $4.80        - Press 2\n" +
                            "\nLarge: $5.30         - Press 3\n" +
                            "\nExtra Large: $5.90   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "3":

                        Console.WriteLine("You have selected a Chai Latte\n" +
                            "Select Size: " +
                            "\n------------------------------" +
                            "\nSmall: $5.00         - Press 1\n" +
                            "\nMedium: $5.50        - Press 2\n" +
                            "\nLarge: $6.00         - Press 3\n" +
                            "\nExtra Large: $6.50   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "4":

                        Console.WriteLine("You have selceted a Short Black\n" +
                            "Select Size:" +
                            "\n------------------------------" +
                            "\nSmall: $4.00         - Press 1\n" +
                            "\nMedium: $4.50        - Press 2\n" +
                            "\nLarge: $5.00         - Press 3\n" +
                            "\nExtra Large: $5.50   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "5":

                        Console.WriteLine("You have selceted a Long Black\n" +
                            "Select Size:" +
                            "\n------------------------------" +
                            "\nSmall: $5.00         - Press 1\n" +
                            "\nMedium: $5.50        - Press 2\n" +
                            "\nLarge: $6.00         - Press 3\n" +
                            "\nExtra Large: $6.50   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "6":

                        Console.WriteLine("You have selceted a Cappuccino\n" +
                            "Select Size:" +
                            "\n------------------------------" +
                            "\nSmall: $5.50         - Press 1\n" +
                            "\nMedium: $6.00        - Press 2\n" +
                            "\nLarge: $6.50         - Press 3\n" +
                            "\nExtra Large: $7.00   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "7":

                        Console.WriteLine("You have selceted a Mocha\n" +
                            "Select Size:" +
                            "\n------------------------------" +
                            "\nSmall: $5.40         - Press 1\n" +
                            "\nMedium: $5.90        - Press 2\n" +
                            "\nLarge: $6.40         - Press 3\n" +
                            "\nExtra Large: $6.90   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");
                        break;
                    case "8":
                        Console.WriteLine("You have selected an Americano\n" +
                            "Select Size:" +
                            "\n------------------------------ " +
                            "\nSmall: $4.50         - Press 1\n" +
                            "\nMedium: $5.00        - Press 2\n" +
                            "\nLarge: $5.50         - Press 3\n" +
                            "\nExtra Large: $6.00   - Press 4" +
                            "\n------------------------------" +
                            "\nCancel - Press 5\n");

                        



                        break;
                    case "9":
                        Console.WriteLine(
                            "\nFlat White:\n" +
                        "An espresso-based drink that contains steamed milk. Flat Whites originated in New Zealand in the 1980s and several years later, Flat Whites began to appear on menus in countries such as the United States and the United Kingdom. Flat Whites are often mistaken for Lattes but what separates them is that Flat Whites have a stronger coffee taste, giving Lattes a sweeter taste.\n" +
                            
                            "\nLatte:\n" +
                            "A milk coffee containing a silky layer of foam. Lattes are usually made up of one or two shots of espresso, steamed milk and topped with a thin layer of frothed milk. The first origins of Lattes are not very clear as people have been combining coffee and milk for centuries. Modern Lattes that people know today originated in Seattle, United States during the 1980s.\n" +
                        "\nChai Latte:\n" +
                        "A hot, milky, fragrant, gently spicy type of coffee. What makes Chai Lattes different from other coffees is that doesn't contain any coffee. Chai Lattes contain a sweetened chai syrup or powder allowing them to be made quickly. Chai Lattes originated in India thousands of years ago and have spread in popularity over the last two centuries.\n" +
                        "\nShort Black:\n" +
                        "A single espresso shot without milk. Short Blacks are great to have when you just want to enjoy the pure taste of coffee. Short Blacks have a very strong taste as they only contain an espresso shot and hot water. It isn’t too clear where short black coffees originate from, however they are globally popular appearing on most Cafe menus. \n" +
                        "\nLong Black:\n" +
                        "An espresso-based drink popular in Australia and New Zealand. The only ingredients used in a long black is espresso and hot water. Long Blacks are traditionally made by pouring a double shot of espresso or ristretto over 100 to 120ml of hot water from the espresso machine. Long Blacks have always been confused with Americanos, but their main difference is how the hot water is mixed with the espresso. An Americano is made by pouring hot water over espresso while a Long Black is made in the opposite way.  \n" +
                        "\nCappuccino:\n" +
                        "A perfect balance of espresso steamed milk and foam. Cappuccinos are all about the structure of splitting the three elements into equal thirds. Cappuccinos are supposed to be rich but not acidic, also they should have a mildly sweet flavouring from the milk. The milk is not actually mixed in with the Cappuccino giving it a stronger flavour. Cappuccinos originated in Italy and then made their way across the world we’re they are now seen on most cafe menus.  \n" +
                        "\nMocha:\n" +
                        "A variant of a latte being a deliciously sweet, nutty and chocolatey flavoured coffee. Mochas is an espresso-based drink; however, it is different from most other coffees due to its sweeter taste. Mochas are made with a shot of espresso, followed by milk and cream. It can also be combined with chocolate powder or syrup.  The term ‘mocha’ is a specific type of coffee bean which is only grown in the city of Mocha, Yemen. \n" +
                        "\nAmericano:\n" +
                        "It is simply just hot water and espresso. They are made by adding the espresso first, then the crema is added after to give a mellow taste. Americanos originate back to World War II when American soldiers were stationed in Italy, the American soldiers didn’t like the strong espresso that was popular in Italy, so they tried to recreate their beloved drip coffee from America by adding water to an espresso shot. This is now known today is an Americano. \n");

                        break;
                    default:
                        Console.WriteLine("Sorry, that is not an option");
                        break;


                       




                }









                //The users coffee will start to be prepared
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
                Console.WriteLine("Pouring the coffee\n");

                Console.WriteLine("Thank you for your order!");





                while (true)
                {
                    Console.WriteLine("Would you like to run the program again\n" +
                        "Run Again  - Press 1\n" +
                        "Exit       - Press 2 ");
                        

                    string proceed = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(proceed))
                    {
                        proceed = proceed.ToLower().Substring(0, 1);

                        if (proceed.Equals("1") || proceed.Equals("2"))
                        {
                            return proceed;
                        }
                    }
                    Console.WriteLine("Please enter either options '1' or '2'\n\n");

                }



            }




        }
       


        static void Main()
        {

            Console.WriteLine("Hello, what type of coffee would like to order\n");



            string reRun = "1";



            do
            {

                OneCoffee();
                


            }

            while (reRun.Equals("2"));
            Console.WriteLine("\nThank you for using the coffee ordering process, have a nice day!");

        }






    }


















}



