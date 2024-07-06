using System;
using System.Collections.Generic;

class CoffeeOrderingProcess
{
    static void Main(string[] args)
    {
        bool ordering = true;
        while (ordering)
        {
            Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu = GetCoffeeMenu();
            List<Tuple<string, string, string, double>> itemsOrdered = new List<Tuple<string, string, string, double>>();
            double orderTotal = 0.00;

            //Introduce the user to the program
            Console.WriteLine("Welcome to Dream Coffees");

            OneCoffee(coffeeMenu);

            GetCoffeeOrder(coffeeMenu, itemsOrdered, ref orderTotal);

            if (itemsOrdered.Count > 0)
            {
                string orderType = RecieveOrder();

                double deliveryFee = 3.00;
                string name, phoneNumber = "", address = "";
                GetCustomerDetails(orderType, out name, out phoneNumber, out address, ref orderTotal, deliveryFee);
                WaitingOrder();

                //Let the user know when their coffee order is ready
                Console.WriteLine("Your coffee order is now ready");

                DisplayOrderSummary(orderType, name, phoneNumber, address, itemsOrdered, orderTotal);


            }
            else
            {
                Console.WriteLine("Your order has been cancelled.");
            }

            //Allow the user to run the program again
            ordering = false;
            while (true)
            {
                Console.Write("Would you like to place another order?\n" +
                    "Yes - Press 1\n" +
                    "No  - Press 2\n");

                string response = Console.ReadLine();

                if (response == "1")
                {
                    ordering = true;
                    Console.WriteLine("Thank you ordering again!");
                    break;
                }
                else if (response == "2")
                {
                    ordering = false;
                    Console.WriteLine("\nThank you for ordering at Dream Coffees, have a nice day!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nError: please enter either '1' or '2'");
                }
            }
        }
    }

    static Dictionary<int, Dictionary<int, Tuple<string, double>>> GetCoffeeMenu()
    {
        return new Dictionary<int, Dictionary<int, Tuple<string, double>>>
        {
            {
                1, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Flat White", 2.50) },
                    { 2, Tuple.Create("Flat White", 3.00) },
                    { 3, Tuple.Create("Flat White", 3.00) }

                }
            },
            {
                2, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Latte", 3.00) },
                    { 2, Tuple.Create("Latte", 3.50) },
                    { 3, Tuple.Create("Latte", 3.50) }

                }
            },
            {
                3, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Chai Latte", 3.50) },
                    { 2, Tuple.Create("Chai Latte", 4.00) },
                    { 3, Tuple.Create("Chai Latte", 4.00) },

                }
            },
            {
                4, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Short Black", 3.50) },
                    { 2, Tuple.Create("Short Black", 4.00) },
                    { 3, Tuple.Create("Short Black", 4.00) },


                }

            },
            {
                5, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Long Black", 4.00) },
                    { 2, Tuple.Create("Long Black", 4.50) },
                    { 3, Tuple.Create("Long Black", 4.50) },

                }
            },
            {
                6, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Cappuccino", 4.00) },
                    { 2, Tuple.Create("Cappuccino", 4.50) },
                    { 3, Tuple.Create("Cappuccino", 4.50) },

                }
            },
            {
                7, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Mocha", 4.00) },
                    { 2, Tuple.Create("Mocha", 4.50) },
                    { 3, Tuple.Create("Mocha", 4.50) },

                }
            },
            {
                8, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Americano", 4.00) },
                    { 2, Tuple.Create("Americano", 4.50) },
                    { 3, Tuple.Create("Americano", 4.50) },

                }
            },
            {
                9, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Cortado", 4.00) },
                    { 2, Tuple.Create("Cortado", 4.50) },
                    { 3, Tuple.Create("Cortado", 4.50) },

                }
            },
            {
                10, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Ristretto", 4.00) },
                    { 2, Tuple.Create("Ristretto", 4.50) },
                    { 3, Tuple.Create("Ristretto", 4.50) },

                }
            },
            {
                11, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Affogato", 4.00) },
                    { 2, Tuple.Create("Affogato", 4.50) },
                    { 3, Tuple.Create("Affogato", 4.50) },

                }
            },
            {
                12, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Iced Coffee", 4.00) },
                    { 2, Tuple.Create("Iced Coffee", 4.50) },
                    { 3, Tuple.Create("Iced Coffee", 4.50) },

                }
            }

        };
    }

    static void OneCoffee(Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu)
    {
        //Display a menu of coffees and their prices for the user 
        Console.WriteLine("\n-------- Menu --------");

        foreach (var coffee in coffeeMenu)
        {
            string coffeeName = coffee.Value[1].Item1;
            Console.WriteLine($"{coffee.Key}. {coffeeName}:");
            foreach (var size in coffee.Value)
            {

                string sizeName = GetSizeName(size.Key);

                Console.WriteLine($"  {size.Key}. {sizeName}: ${size.Value.Item2:F2}");


            }
            Console.WriteLine("----------------------");


        }
        //Let the user know that they can only order a maximum of five coffees.
        Console.Write("\n----------------------------------------------------------------------------------\n");
        Console.Write("Please take your time to scroll though our wide range of coffee types!\n");
        Console.Write("Once you would like to order a coffee, type the number that collates to the coffee\n");
        Console.Write("Note: You can only order a maximum of 5 coffees");
        Console.Write("\n----------------------------------------------------------------------------------\n");
    }
    static void WaitingOrder()

    {

        Console.WriteLine("\nYour order is now being prepared!");

        Console.WriteLine("Expected waiting time: 6 seconds\n");

        Thread.Sleep(1000);
        Console.WriteLine("Measuring the brew ratio");

        Thread.Sleep(1000);
        Console.WriteLine("Grinding the coffee beans");

        Thread.Sleep(1000);

        Console.WriteLine("Boiling the water");
        Thread.Sleep(1000);

        Console.WriteLine("Placing coffee into the filter");
        Thread.Sleep(1000);

        Console.WriteLine("Pouring the coffee\n");

    }

    static void GetCoffeeOrder(Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu, List<Tuple<string, string, string, double>> itemsOrdered, ref double orderTotal)
    {
        //Let the user know how to finish or cancel their order.
        bool addingItems = true;
        while (addingItems && itemsOrdered.Count < 5)
        {
            Console.Write("\nFinish Order  - Type 13\n" +
              "Cancel Order  - Type 14\n");

            string input = Console.ReadLine();

            if (input.ToLower() == "13")
            {
                addingItems = false;
            }
            else if (input.ToLower() == "14")
            {
                itemsOrdered.Clear();
                orderTotal = 0.00;
                addingItems = false;
            }
            //Get the user to select a size for their coffee.
            else if (int.TryParse(input, out int coffeeChoice) && coffeeMenu.ContainsKey(coffeeChoice))
            {
                Console.Write($"Please enter the size for {coffeeMenu[coffeeChoice][1].Item1}" +
                   $"\nSmall       - Press 1\n" +
                   $"Medium      - Press 2\n" +
                   $"Large       - Press 3\n");

                string sizeInput = Console.ReadLine();

                if (int.TryParse(sizeInput, out int sizeChoice) && coffeeMenu[coffeeChoice].ContainsKey(sizeChoice))
                {
                    string coffeeName = coffeeMenu[coffeeChoice][sizeChoice].Item1;
                    string sizeName = GetSizeName(sizeChoice);
                    double price = coffeeMenu[coffeeChoice][sizeChoice].Item2;
                    itemsOrdered.Add(Tuple.Create(coffeeMenu[coffeeChoice][sizeChoice].Item1, sizeName, coffeeName, price));
                    orderTotal += price;
                }
                else
                {
                    Console.WriteLine("Error: please enter the correct input for the size if you want the coffee");
                }
            }
            else
            {
                Console.WriteLine("Error: please enter an option between 1 - 14");
            }
        }

        //Let the user know when they have ordered the maximum number of coffees
        if (itemsOrdered.Count == 5)
        {
            Console.WriteLine("You have reached the maximum number of 5 coffees.");
        }
    }

    static string RecieveOrder()
    {
        //Give the user the option to receive their order from either delivery or pick up 
        string orderType = "";
        while (orderType != "a" && orderType != "b")
        {
            Console.Write("\nHow will you be receiving your order?\n" +

                "-------------------------------\n" +
                "Delivery - Press a\n" +
                "This will cost an additional $3\n\n" +
                "Pick up  - Press b\n" +
                "-------------------------------\n");
            orderType = Console.ReadLine().ToLower();

            if (orderType != "a" && orderType != "b")
            {
                Console.WriteLine("Invalid order type. Please enter either 'a' or 'b'.");
            }
        }
        return orderType;
    }

    static void GetCustomerDetails(string orderType, out string name, out string phoneNumber, out string address, ref double orderTotal, double deliveryFee)
    {
        name = "";
        phoneNumber = "";
        address = "";

        if (orderType == "a")
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your phone number: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Please enter your address: ");
            address = Console.ReadLine();

            orderTotal += deliveryFee;
        }
        else if (orderType == "b")
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }
    }

    static void DisplayOrderSummary(string orderType, string name, string phoneNumber, string address, List<Tuple<string, string, string, double>> itemsOrdered, double orderTotal)
    {
        Console.WriteLine("\nOrder Summary:");

        //Display customers details 
        Console.WriteLine($"------------- Customer Details -------------\n");
        Console.WriteLine($"Order Type: {orderType}");
        Console.WriteLine($"Name: {name}");

        if (orderType == "1")
        {
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Address: {address}");
        }

        //Display everything the user has ordered with the individual prices 
        Console.WriteLine("\n-------------- Order of items --------------\n");

        foreach (var item in itemsOrdered)
        {
            Console.WriteLine($"- One {item.Item2} {item.Item1}:  ${item.Item4:F2}");
        }


        //Display the total cost from everything they've ordered 

        Console.WriteLine("\n-------------------------------------------");

        Console.WriteLine($"Order Total: ${orderTotal:F2}");



        Console.WriteLine("-------------------------------------------\n");
    }

    static string GetSizeName(int sizeKey)
    {
        return sizeKey switch
        {
            1 => "Small",
            2 => "Medium",
            3 => "Large",
            _ => ""
        };
    }
}
