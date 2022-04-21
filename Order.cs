using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int OrderNum { get; set; } 
    public DateTime OrderDate { get; }
    public List<OrderItem> OrderItems { get; }
   

    public Order(int orderNum, DateTime orderDate, List<Item> items)
    {
        OrderNum = orderNum;
        OrderDate = orderDate;
        OrderItems = new List<OrderItem>();
        
        foreach (var item in items)
        {
            bool isItemAdded = IsItemAlreadyAdded(item);
            
            if (!isItemAdded)
            {
                int quantity = CountProducts(items, item);
                OrderItems.Add(new OrderItem(item, quantity));
            }
        }
    }

    private int CountProducts(List<Item> itemsList, Item item)
    {
        return itemsList.Count(i => i.ItemName == item.ItemName);
    }

    private bool IsItemAlreadyAdded(Item item)
    {
        return OrderItems.Any(i => i.Item.ItemName == item.ItemName);
    }

    public decimal CountPrice()
    {
        decimal price = 0;
        
        for (int i = 0; i < OrderItems.Count; i++)
        {
            price += OrderItems[i].Item.ItemPrice * OrderItems[i].Quantity;
        }
        return price;
    }

    public int CountItem()
    {
        int selledItemQuantity = 0;
        
        for (int i = 0; i < OrderItems.Count; i++)
        {
            selledItemQuantity += OrderItems[i].Quantity;
        }
        return selledItemQuantity;
    }

    public int CountItemChosen(int index)
    {
        int selledItemQuantity = 0;
        
        for (int i = 0; i < OrderItems.Count; i++)
        {
            if (OrderItems[i].Item.ItemIndex == index)
            {
                selledItemQuantity += OrderItems[i].Quantity;
            }
        }
        return selledItemQuantity;
    }


}
