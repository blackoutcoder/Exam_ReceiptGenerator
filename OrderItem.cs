using System;

public class OrderItem
{
	public Item Item { get; }
	public int Quantity { get; }

	public OrderItem(Item item, int quantity)
    {
		Item = item;
		Quantity = quantity;
    }
}
