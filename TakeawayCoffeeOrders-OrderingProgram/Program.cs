using System;
using System.Collections.Generic;

namespace TakeawayCoffeeOrders
{
    class CoffeeOrderingProcess
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu = GetCoffeeMenu();
            List<string> itemsOrdered = new List<string>();
            double orderTotal = 0.00;

            Console.WriteLine("Welcome to Dream Coffees\n");

            string orderType = GetOrderType();
            string name, phoneNumber = "", address = "";
            double deliveryFee = 3.00;

            GetCustomerDetails(orderType, out name, out phoneNumber, out address, ref orderTotal, deliveryFee);
            DisplayCoffeeMenu(coffeeMenu);

            CaptureOrderItems(coffeeMenu, itemsOrdered, ref orderTotal);







            DisplayOrderSummary(orderType, name, phoneNumber, address, itemsOrdered, coffeeMenu, orderTotal);

            Console.WriteLine("Thank you for your order!");
        }

        static Dictionary<int, Dictionary<int, Tuple<string, double>>> GetCoffeeMenu()
        {

            return new Dictionary<int, Dictionary<int, Tuple<string, double>>>
            {
                {
                    1, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Espresso", 2.50) },
                        { 2, Tuple.Create("Espresso", 3.00) },
                        { 3, Tuple.Create("Espresso", 3.50) }
                    }
                },
                {
                    2, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Americano", 3.00) },
                        { 2, Tuple.Create("Americano", 3.50) },
                        { 3, Tuple.Create("Americano", 4.00) }
                    }
                },
                {
                    3, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Latte", 3.50) },
                        { 2, Tuple.Create("Latte", 4.00) },
                        { 3, Tuple.Create("Latte", 4.50) }
                    }
                },
                {
                    4, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Cappuccino", 3.50) },
                        { 2, Tuple.Create("Cappuccino", 4.00) },
                        { 3, Tuple.Create("Cappuccino", 4.50) }
                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    6, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                },
                {
                    5, new Dictionary<int, Tuple<string, double>>
                    {
                        { 1, Tuple.Create("Mocha", 4.00) },
                        { 2, Tuple.Create("Mocha", 4.50) },
                        { 3, Tuple.Create("Mocha", 5.00) }

                    }
                }
            };
        }

        static void DisplayCoffeeMenu(Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu)
        {
            Console.WriteLine("\n------------------------------- Menu -------------------------------\n\n" +

                "Small: 1, Medium: 2, Large: 3, Extra Large: 4\n");
            foreach (var coffee in coffeeMenu)
            {
                Console.WriteLine($"{coffee.Key}. {coffee.Value[1].Item1}:");
                foreach (var size in coffee.Value)
                {
                    Console.WriteLine($"  - {size.Key}: ${size.Value.Item2}");
                }
            }
        }

        static void CaptureOrderItems(Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu, List<string> itemsOrdered, ref double orderTotal)
        {
            bool addingItems = true;
            while (addingItems)
            {
                Console.Write(
                    "\nOnce you are finished with your order, type 13:\n");
                string input = Console.ReadLine();

                if (input.ToLower() == "13")
                {
                    addingItems = false;
                }
                else if (int.TryParse(input, out int coffeeChoice) && coffeeMenu.ContainsKey(coffeeChoice))
                {
                    Console.Write($"Please enter the size for your{coffeeMenu[coffeeChoice][1].Item1}\n");
                    string sizeInput = Console.ReadLine();

                    if (int.TryParse(sizeInput, out int sizeChoice) && coffeeMenu[coffeeChoice].ContainsKey(sizeChoice))
                    {
                        string coffeeName = coffeeMenu[coffeeChoice][sizeChoice].Item1;
                        itemsOrdered.Add(coffeeName);
                    orderTotal += coffeeMenu[coffeeChoice][sizeChoice].Item2;
                }
                else
                {
                    Console.WriteLine("Invalid size choice. Please select from the available sizes.");
                }
                }
                else
                {
                    Console.WriteLine("Invalid coffee choice. Please select from the menu.");
                }
            }
        }

        static string GetOrderType()
        {
            string orderType = "";
            while (orderType != "1" && orderType != "2")
            {
                Console.Write("How will you be receiving your order?\n" +
                    "Delivery - Press 1\n " +
                    "Pick up  - Press 2");
                orderType = Console.ReadLine().ToLower();

                if (orderType != "1" && orderType != "2")
                {
                    Console.WriteLine("Error: please enter either '1' or '2'.");
                }
            }
            return orderType;
        }

        static void GetCustomerDetails(string orderType, out string name, out string phoneNumber, out string address, ref double orderTotal, double deliveryFee)
        {
            name = "";
            phoneNumber = "";
            address = "";

            if (orderType == "delivery")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();

                Console.Write("Please enter your phone number: ");
                phoneNumber = Console.ReadLine();

                Console.Write("Please enter your address: ");
                address = Console.ReadLine();

                orderTotal += deliveryFee;
            }
            else if (orderType == "pickup")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            }
        }

        static void DisplayOrderSummary(string orderType, string name, string phoneNumber, string address, List<string> itemsOrdered, Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu, double orderTotal)
        {
            Console.WriteLine("\nOrder Summary:");
            Console.WriteLine($"Order Type: {orderType}");
            Console.WriteLine($"Name: {name}");

            if (orderType == "delivery")
            {
                Console.WriteLine($"Phone Number: {phoneNumber}");
                Console.WriteLine($"Address: {address}");
            }

            Console.WriteLine("Items Ordered:");
            foreach (string item in itemsOrdered)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine($"Order Total: ${orderTotal}");
        }
    }
}

