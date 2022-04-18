using System;
using System.Collections.Generic;

public class ItemRepository
{
    private List<Item> Items;

    public ItemRepository()
    {
        Items = new List<Item>();

        Items.Add(new Item("Pork", "Meat products", (decimal)4.00, 1));
        Items.Add(new Item("Salmon", "Fish products", (decimal)8.00, 2));
        Items.Add(new Item("Chicken fillets", "Meat products", (decimal)3.00, 3));
        Items.Add(new Item("Potatoes", "Vegetables", (decimal)0.50, 4));
        Items.Add(new Item("Tomatoes", "Vegetables", (decimal)0.80, 5));
        Items.Add(new Item("Cheese", "Milk products", (decimal)2.10, 6));
        Items.Add(new Item("Milk", "Milk products", (decimal)1.00, 7));
        Items.Add(new Item("Bread", "Bakery", (decimal)1.20, 8));
        Items.Add(new Item("Butter", "Milk products", (decimal)1.89, 9));
        Items.Add(new Item("Tuna chunks", "Fish products", (decimal)2.99, 10));
    }

    public List<Item> Retrieve()
    {
        return Items;
    }
}
