using System;
using System.Collections.Generic;

public class Methods
{
    public void PrintProductList()
    {
        Console.ForegroundColor = ConsoleColor.Green;                                                                       //Changes text color to green in Console
        Console.WriteLine(" - Generating Receipts for Orders...");
        Console.WriteLine();
        ItemRepository itemRep = new ItemRepository();
        List<Item> itemsList = itemRep.Retrieve();
        Console.WriteLine(" - Products for sell: ");
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        for (int i = 0; i < itemsList.Count; i++)
        {
            Console.Write($"- {itemsList[i].ItemName}, {itemsList[i].ItemDescription}, {itemsList[i].ItemPrice} Eur.\r\n");
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------------------------------");
        Console.ResetColor();
    }
    public void PrintOrdersData()
    {
        OrderRepository orderRepository = new OrderRepository();
        List<Order> orders = orderRepository.Retrieve();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($">Number of Orders: {orders.Count}");
        Console.WriteLine();
        decimal totalPrice = 0;
        int totalItems = 0;
        int totalBest = 0;
        for (int i = 0; i < orders.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($">Order nr.{i + 1} details: ");
            Console.WriteLine($">Order data: {orders[i].OrderDate}.");
            for (int j = 0; j < orders[i].OrderItems.Count; j++)
            {
                Item item = orders[i].OrderItems[j].Item;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(
                    $" - Product: {item.ItemName}; " +
                    $" - Product description: {item.ItemDescription}; " +
                    $" - Product price/pcs.: {item.ItemPrice}; " +
                    $" - Quantity: {orders[i].OrderItems[j].Quantity}.");
            }
            int itemIndex1 = orders[i].CountItemChosen(11);
            int itemsBought = orders[i].CountItem();
            decimal priceToPay = orders[i].CountPrice();
            Console.WriteLine($">Total price: {priceToPay} Eur.");
            Console.WriteLine();
            totalPrice += priceToPay;
            totalItems += itemsBought;
            totalBest += itemIndex1;
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        
        Console.WriteLine($">Total payed: {totalPrice} Eur.");
        Console.WriteLine();
        Console.WriteLine($">Total products sold: {totalItems} pcs.");                                 //Total products sold
        Console.WriteLine();
        Console.WriteLine($">Total Brandy sold {totalBest} pcs for {(totalBest) * 12.49} Eur.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($">{orders.Count} receipt(s) successfully generated");
        Console.WriteLine(">Enter an order number to view details and press ENTER...");                 // Code to view an order you want .
        string orderNumber = Console.ReadLine();
        while (!int.TryParse(orderNumber, out int num) == true)                                         //Checks if an entered character is not a <string>                                                               
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($">Enter an <int> value and press ENTER...");                             //while you are entering a <string> program will asks you to enter an <int> type value.
            orderNumber = Console.ReadLine();
        }
        if (Convert.ToInt32(orderNumber) > 0 && Convert.ToInt32(orderNumber) < orders.Count)            //If Order number is higher than 0 and lower than a number of generated orders - true 
        {
            Console.WriteLine($">Order nr.{orderNumber} details: ");
            Console.WriteLine($">Order data: {orders[Convert.ToInt32(orderNumber)].OrderDate}.");       //Printing Order Detailes 
            for (int j = 0; j < orders[Convert.ToInt32(orderNumber)].OrderItems.Count; j++)             //Printing Order Detailes 
            {                                                                                           //Printing Order Detailes 
                Item item = orders[Convert.ToInt32(orderNumber)].OrderItems[j].Item;
                Console.ForegroundColor = ConsoleColor.White;                                           //Printing Order Detailes 
                Console.WriteLine(                                                                      //Printing Order Detailes 
                    $" - Product : {item.ItemName}; " +                                                  //Printing Order Detailes 
                    $" - Product description : {item.ItemDescription}; " +                               //Printing Order Detailes 
                    $" - Product price/pcs. : {item.ItemPrice}; " +                                      //Printing Order Detailes 
                    $" - Quantity: {orders[Convert.ToInt32(orderNumber)].OrderItems[j].Quantity}.");    //Printing Order Detailes 
            }
            decimal priceToPay = orders[Convert.ToInt32(orderNumber)].CountPrice();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($">Total price: {priceToPay} Eur.");
            Console.WriteLine();                                                                        //Printing Order Detailes 
            Console.ReadLine();                                                                         //Printing Order Detailes 
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;                                                 //Changes the text color in console
            Console.WriteLine("Invalid order number entered, press ENTER to close...");                 //If entered order number is invalid - writes a 'message' in console
            Console.ReadLine();
        }
        
    }

    public void Printer()                                                                               //Printer() method
    {
        PrintProductList();                                                                             //Calls the PrintProductList() method
        PrintOrdersData();                                                                              //Calls the PrintOrdersData() method
    }
}
