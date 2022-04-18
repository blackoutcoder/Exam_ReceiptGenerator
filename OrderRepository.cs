using System;
using System.Collections.Generic;
using System.Linq;

public class OrderRepository
{
    
	private List<Order> OrdersList { get; } //Daclaring a List of <Order> class named 'OrdersList'.
	public OrderRepository() // OrderRepository constructor 
    {
        OrdersList = new List<Order>(); //Creating an emtry 'OredersList'
        OrderGenerator(); //Calling OrderGenerator() method  
    }
    public void OrderGenerator() //OrderGenerator() method 
    {
        ItemRepository itemRepository = new ItemRepository(); //Declaring itemRepository as a new ItemRepository()

        Console.WriteLine(">Enter how many orderes to generate...."); //Asks how many orders to generate
        string orderNumber = Console.ReadLine();                      //Reads the console and daclares entered string to 'orderNumber' variable
        while (!int.TryParse(orderNumber, out int num) == true) //Checks if an entered character is not a <string>                                                               
        {
            Console.WriteLine($">Enter an <int> value and press ENTER...");//while you are entering a <string> program will asks you to enter an <int> type value.
            orderNumber = Console.ReadLine();
        }

        for (int i = 0; i < Convert.ToInt32(orderNumber); i++)                  //'For' loop is adding a new Order to 'OrderList' - 'orderNumber' times :))) if you understand what i mean))) 
        {
            OrdersList.Add(new Order(DateTime.Now, itemRepository.Retrieve()));  //Item list is takes from itemRepository
        }

    }
    public List<Order> Retrieve() // Retrieve method, returns 'OrdersList' List  of <Order> class
    {
        return OrdersList;
    }

    public Order Retrieve(int uniqueOrderId)
    {
        return OrdersList[uniqueOrderId];
    }
}
