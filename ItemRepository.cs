using System;
using System.Collections.Generic;

public class ItemRepository
{
    private List<Item> Items;

    public ItemRepository()
    {
        Items = new List<Item>();

        Items.Add(new Item("Pork", "Meat products", (decimal)4.00, 1));              //Static item list, like products for sell in the shop.
        Items.Add(new Item("Salmon", "Fish products", (decimal)8.00, 2));            // Add/Remove option could be added in perspective
        Items.Add(new Item("Chicken fillets", "Meat products", (decimal)3.00, 3));   
        Items.Add(new Item("Potatoes", "Vegetables", (decimal)0.50, 4));
        Items.Add(new Item("Tomatoes", "Vegetables", (decimal)0.80, 5));
        Items.Add(new Item("Cheese", "Milk products", (decimal)2.10, 6));
        Items.Add(new Item("Milk", "Milk products", (decimal)1.00, 7));
        Items.Add(new Item("Bread", "Bakery", (decimal)1.20, 8));
        Items.Add(new Item("Butter", "Milk products", (decimal)1.89, 9));
        Items.Add(new Item("Tuna chunks", "Fish products", (decimal)2.99, 10));
        Items.Add(new Item("Brandy", "Alcohol", (decimal)12.49, 11));
        Items.Add(new Item("Visky", "Alcohol", (decimal)8.43, 12));
        Items.Add(new Item("Beef", "Meat products", (decimal)4.59, 13));
        Items.Add(new Item("Bananas", "Fruits", (decimal)0.89, 14));
        Items.Add(new Item("Apples", "Fruits", (decimal)0.80, 15));
        Items.Add(new Item("Cherries", "Fruits", (decimal)2.10, 16));
        Items.Add(new Item("Beer", "Alcohol", (decimal)1.00, 17));
        Items.Add(new Item("Coca-cola", "Drinks", (decimal)1.20, 18));
        Items.Add(new Item("Fanta", "Drinks", (decimal)1.89, 19));
        Items.Add(new Item("Sprite", "Drinks", (decimal)2.99, 20));
    }

    public List<Item> Generate()                                                        //Generate() method generates a random list of orders from an 'Items' list
    {
        Random random = new Random();
        List<Item> items = new List<Item>();
        int numberOfItems = random.Next(1,50);
        for (int i = 0; i < numberOfItems; i++)
        {
            int ItemNumber = random.Next(20);
            items.Add(Items[ItemNumber]);
        }
        return items;
    }

    public List<Item> Retrieve()
    {
        return Items;
    }

    
}
