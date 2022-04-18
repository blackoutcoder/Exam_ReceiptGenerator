using System;
using System.Collections.Generic;

public class DataPrinter
{
    public void PrintProductList()
    {
        Console.WriteLine(" - Generating Receipts for Orders...");
        Console.WriteLine();
        ItemRepository prodRep = new ItemRepository();
        List<Item> itemsList = prodRep.Retrieve();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" - Products for sell: ");
        Console.ResetColor();
        Console.WriteLine();
        for (int i = 0; i < itemsList.Count; i++)
        {
            Console.Write($"- {itemsList[i].ItemName}, {itemsList[i].ItemDescription}, {itemsList[i].ItemPrice} Eur.\r\n");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------------------------------------");
        Console.ResetColor();
    }
    public void PrintOrdersData()
    {
        OrderRepository orderRepository = new OrderRepository();
        List<Order> orders = orderRepository.Retrieve();
        Console.WriteLine($">Number of Orders: {orders.Count}");
        Console.WriteLine();
        decimal totalPrice = 0;
        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($">Order nr.{i + 1} datails: ");
            Console.WriteLine($">Order data: {orders[i].OrderDate}.");
            for (int j = 0; j < orders[i].OrderItems.Count; j++)
            {
                Item item = orders[i].OrderItems[j].Item;
                Console.WriteLine(
                    $" - Product: {item.ItemName}; " +
                    $" - Product description: {item.ItemDescription}; " +
                    $" - Product price/unt.: {item.ItemPrice}; " +
                    $" - Quantity: {orders[i].OrderItems[j].Quantity}.");
            }

            decimal priceToPay = orders[i].CountPrice();
            Console.WriteLine($">Total price: {priceToPay} Eur.");
            Console.WriteLine();
            totalPrice += priceToPay;
        }

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(">Total payed: ");
        Console.ResetColor();
        Console.WriteLine(totalPrice + " Eur.");
        Console.WriteLine();
        Console.WriteLine($">{orders.Count} receipt(s) successfully generated");
        Console.ReadLine();
    }
}
