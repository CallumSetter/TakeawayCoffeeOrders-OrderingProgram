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
            List<Tuple<string, string, double>> itemsOrdered = new List<Tuple<string, string, double>>();
            double orderTotal = 0.00;

            Console.WriteLine("Welcome to Dream Coffees\n");

            DisplayCoffeeMenu(coffeeMenu);

            CaptureOrderItems(coffeeMenu, itemsOrdered, ref orderTotal);

            if (itemsOrdered.Count > 0)
            {
                string orderType = GetOrderType();

                double deliveryFee = 3.00;
                string name, phoneNumber = "", address = "";
                GetCustomerDetails(orderType, out name, out phoneNumber, out address, ref orderTotal, deliveryFee);
                WaitingOrder();
                Console.WriteLine("Your order is now ready!\n");
                DisplayOrderSummary(orderType, name, phoneNumber, address, itemsOrdered, orderTotal);

                Console.WriteLine("Thank you for your order, have a nice day!");
            }
            else
            {
                Console.WriteLine("Your order has been cancelled");
            }

            Console.Write("Would you like to place another order?\n" +
                "Yes - Press 1\n" +
                "No  - Press 2\n");
            string continueOrder = Console.ReadLine().ToLower();
            ordering = (continueOrder == "1");
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
                    { 2, Tuple.Create("Flat White", 3.50) },
                    { 3, Tuple.Create("Flat White", 3.50) },
                    { 4, Tuple.Create("Flat White", 4.00) }
                }
            },
            {
                2, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Latte", 3.00) },
                    { 2, Tuple.Create("Latte", 3.50) },
                    { 3, Tuple.Create("Latte", 4.00) },
                    { 4, Tuple.Create("Latte", 4.50) }
                }
            },
            {
                3, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Chai Latte", 3.50) },
                    { 2, Tuple.Create("Chai Latte", 4.00) },
                    { 3, Tuple.Create("Chai Latte", 4.50) },
                    { 4, Tuple.Create("Chai Latte", 5.00) }
                }
            },
            {
                4, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Short Black", 3.50) },
                    { 2, Tuple.Create("Short Black", 4.00) },
                    { 3, Tuple.Create("Short Black", 4.50) },
                    { 4, Tuple.Create("Short Black", 5.00) }
                }
            },
            {
                5, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Long Black", 4.00) },
                    { 2, Tuple.Create("Long Black", 4.50) },
                    { 3, Tuple.Create("Long Black", 5.00) },
                    { 4, Tuple.Create("Long Black\n", 5.50) }
                }
            },
            {
                6, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Cappuccino", 4.50) },
                    { 2, Tuple.Create("Cappuccino", 5.00) },
                    { 3, Tuple.Create("Cappuccino", 5.50) },
                    { 4, Tuple.Create("Cappuccino", 6.00) }
                }

            },
            {
                7, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Mocha", 3.50) },
                    { 2, Tuple.Create("Mocha", 4.00) },
                    { 3, Tuple.Create("Mocha", 4.50) },
                    { 4, Tuple.Create("Mocha", 5.00) }
                }

            },
             {
                8, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Americano", 3.00) },
                    { 2, Tuple.Create("Americano", 3.50) },
                    { 3, Tuple.Create("Americano", 4.00) },
                    { 4, Tuple.Create("Americano", 4.50) }
                }

            },
            {
                9, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Cortado", 2.50) },
                    { 2, Tuple.Create("Cortado", 3.00) },
                    { 3, Tuple.Create("Cortado", 3.50) },
                    { 4, Tuple.Create("Cortado", 4.00) }
                }

            },
            {
                10, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Ristretto", 4.00) },
                    { 2, Tuple.Create("Ristretto", 4.50) },
                    { 3, Tuple.Create("Ristretto", 5.00) },
                    { 4, Tuple.Create("Ristretto", 5.50) }
                }

            },
            {
                11, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Affogato", 3.00) },
                    { 2, Tuple.Create("Affogato", 3.50) },
                    { 3, Tuple.Create("Affogato", 4.00) },
                    { 4, Tuple.Create("Affogato", 4.50) }
                }

            },
            {
                12, new Dictionary<int, Tuple<string, double>>
                {
                    { 1, Tuple.Create("Iced Coffee", 4.50) },
                    { 2, Tuple.Create("Iced Coffee", 5.00) },
                    { 3, Tuple.Create("Iced Coffee", 5.50) },
                    { 4, Tuple.Create("Iced Coffee", 6.00) }
                }

            },
        };
    }

    static void DisplayCoffeeMenu(Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu)
    {
        Console.WriteLine("-------------------- Menu --------------------");
        foreach (var coffee in coffeeMenu)
        {
            string coffeeName = coffee.Value[1].Item1;
            Console.WriteLine($"{coffee.Key}. {coffeeName}:");
            foreach (var size in coffee.Value)
            {
                string sizeName = GetSizeName(size.Key);
                Console.WriteLine($"  {size.Key}. {sizeName}: ${size.Value.Item2}");
            }
        }
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

    static void CaptureOrderItems(Dictionary<int, Dictionary<int, Tuple<string, double>>> coffeeMenu, List<Tuple<string, string, double>> itemsOrdered, ref double orderTotal)
    {
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
                addingItems = false;
            }
            else if (int.TryParse(input, out int coffeeChoice) && coffeeMenu.ContainsKey(coffeeChoice))
            {
                Console.Write($"Please enter the size for {coffeeMenu[coffeeChoice][1].Item1}" +
                    $"\nSmall       - Press 1\n" +
                    $"Medium      - Press 2\n" +
                    $"Large       - Press 3\n" +
                    $"Extra Large - Press 4\n");
                string sizeInput = Console.ReadLine();

                if (int.TryParse(sizeInput, out int sizeChoice) && coffeeMenu[coffeeChoice].ContainsKey(sizeChoice))
                {
                    string coffeeName = coffeeMenu[coffeeChoice][sizeChoice].Item1;
                    string sizeName = GetSizeName(sizeChoice);
                    double price = coffeeMenu[coffeeChoice][sizeChoice].Item2;
                    itemsOrdered.Add(Tuple.Create(coffeeName, sizeName, price));
                    orderTotal += price;
                }
                else
                {
                    Console.WriteLine("Error: order has been canceled due to invalid input");
                }
            }
            else
            {
                Console.WriteLine("Error: please enter an option between 1 - 14");
            }
        }

        if (itemsOrdered.Count == 5)
        {
            Console.WriteLine("You have reached the maximum number of 5 coffees.");
        }
    }

    static string GetOrderType()
    {
        string orderType = "";
        while (orderType != "1" && orderType != "2")
        {
            Console.Write("\nHow will you be receiving your order?\n" +
                "Delivery - Press 1\n" +
                "Pick up  - Press 2\n");
            orderType = Console.ReadLine().ToLower();

            if (orderType != "1" && orderType != "2")
            {
                Console.WriteLine("Error: Please enter either '1' or '2'");
            }
        }
        return orderType;
    }

    static void GetCustomerDetails(string orderType, out string name, out string phoneNumber, out string address, ref double orderTotal, double deliveryFee)
    {
        name = "";
        phoneNumber = "";
        address = "";

        if (orderType == "1")
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your phone number: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Please enter your address: ");
            address = Console.ReadLine();

            orderTotal += deliveryFee;
        }
        else if (orderType == "2")
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }
    }

    static void DisplayOrderSummary(string orderType, string name, string phoneNumber, string address, List<Tuple<string, string, double>> itemsOrdered, double orderTotal)
    {
        Console.WriteLine("\nOrder Summary:\n");
        Console.WriteLine($"------------- Customer Details -------------\n");
        Console.WriteLine($"Name: {name}");

        if (orderType == "1")
        {
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Address: {address}");
        }

        Console.WriteLine("\n-------------- Order of items --------------");
        foreach (var item in itemsOrdered)
        {
            Console.WriteLine($"\n- {item.Item1} ({item.Item2}): ${item.Item3}");
        }
        Console.WriteLine("\n--------------------------------------------");

        Console.WriteLine("\n---------------------------------------------------------------------------------------");
        Console.WriteLine($"Total cost: ${orderTotal}");
        Console.WriteLine("Note: If you chose delivery, the additional $3 fee would have been automatically added.");
        Console.WriteLine("---------------------------------------------------------------------------------------\n");
    }

    static string GetSizeName(int sizeKey)
    {
        switch (sizeKey)
        {
            case 1:
                return "Small";
            case 2:
                return "Medium";
            case 3:
                return "Large";
            case 4:
                return "Extra Large";
            default:
                return "";
        }
    }
}
