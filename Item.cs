using System;

public class Item
{
    public string ItemName { get; }
    public string ItemDescription { get; }
    public decimal ItemPrice { get; }
    public int ItemIndex { get; }

    public Item(string itemName, string itemDeskription, decimal itemPrice, int itemIndex) //Item <Class> constructor.
    {
        ItemName = itemName;
        ItemDescription = itemDeskription;
        ItemPrice = itemPrice;
        ItemIndex = itemIndex;
    }
}
