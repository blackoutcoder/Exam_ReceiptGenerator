using System;

public class OrderItem							// An ordered item <class> 
{
	public Item Item { get; }					// Declaring Item class variable - 'Item'
	public int Quantity { get; }				// Decraring an <int> variable 'Quantity' for number of ordered items of that type.

	public OrderItem(Item item, int quantity)   // OrderItem class constructor
    {
		Item = item;
		Quantity = quantity;
    }
}
