using System;

public class Item
{
    public string ItemName { get; } // Declaring a variable for Item Name
    public string ItemDescription { get; } // Declaring a variable for Item description
    public decimal ItemPrice { get; } // Declaring a variable for Item price
    public int ItemIndex { get; } // Declaring a variable for Item index (not used yet, left for future code updates)

    public Item (string itemName, string itemDeskription, decimal itemPrice, int itemIndex) // Item  <Class> constructor.
    {
        ItemName = itemName;
        ItemDescription = itemDeskription;
        ItemPrice = itemPrice;
        ItemIndex = itemIndex;
    }
}
