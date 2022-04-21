using System;
using System.Collections.Generic;
using System.Linq;

public class OrderRepository
{
    
	private List<Order> OrdersList { get; }                                         //Daclaring a List of <Order> class named 'OrdersList'.
	public OrderRepository()                                                        // OrderRepository constructor 
    {
        OrdersList = new List<Order>();                                             //Creating an emtry 'OredersList'
        OrderGenerator();                                                           //Calling OrderGenerator() method  
    }
    public void OrderGenerator()                                                    //OrderGenerator() method 
    {
        ItemRepository itemRepository = new ItemRepository();                       //Declaring itemRepository as a new ItemRepository()
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(">Enter how many orders to generate....");                //Asks how many orders to generate
        Console.ForegroundColor = ConsoleColor.White;
        string orderNumber = Console.ReadLine();                                    //Reads the console and daclares entered string to 'orderNumber' variable
        
        while (!int.TryParse(orderNumber, out int num) == true)                     //Checks if an entered character is not a <string>                                                               
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($">Enter an <int> value and press ENTER...");         //while you are entering a <string> program will asks you to enter an <int> type value.
            Console.ForegroundColor = ConsoleColor.White;
            orderNumber = Console.ReadLine();
        }

        for (int i = 1; i <= Convert.ToInt32(orderNumber); i++)                     //'For' loop is adding a new Order to 'OrderList' - 'orderNumber' times :))) if you understand what i mean))) 
        {
            OrdersList.Add(new Order(i ,DateTime.Now, itemRepository.Generate()));  //Item list is taken from itemRepository
        }

    }
    public List<Order> Retrieve()                                                   // Retrieve method, returns 'OrdersList' List  of <Order> class
    {
        return OrdersList;
    }

    public Order Retrieve(int uniqueOrderId)
    {
        return OrdersList[uniqueOrderId];
    }
}
