using System;
using System.Collections.Generic;
using System.Linq;

public class OrderRepository
{
	private List<Order> OrdersList { get; }
	public OrderRepository()
    {
        OrdersList = new List<Order>();
        ItemRepository itemRepository = new ItemRepository();
        OrderGenerator();
    }

    public List<Order> Retrieve()
    {
        return OrdersList;
    }

    public Order Retrieve(int uniqueOrderId)
    {
        return OrdersList[uniqueOrderId];
    }
    public void OrderGenerator()
    {
        ItemRepository itemRepository = new ItemRepository();

        Console.WriteLine(">Enter how many bill to generate....");
        string billsNumber = Console.ReadLine();
        while (!int.TryParse(billsNumber, out int num) == true)
            {
                Console.WriteLine($">Enter an <int> value and press ENTER...");
                billsNumber = Console.ReadLine();
            }
        
        
        
        for (int i = 0; i < Convert.ToInt32(billsNumber) ; i++)
        {
            OrdersList.Add(new Order(DateTime.Now, itemRepository.Retrieve()));
        }

    }
}
