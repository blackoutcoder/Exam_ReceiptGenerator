using System;
using System.Collections.Generic;

public class ItemRepository
{
    private List<Item> Items;

    public ItemRepository()
    {
        Items = new List<Item>();

        Items.Add(new Item("Pork", "Meat products", 4.00m, 1));                  //Static item list, like products for sell in the shop.
        Items.Add(new Item("Salmon", "Fish products", 8.00m, 2));                // Add/Remove option could be added in perspective
        Items.Add(new Item("Chicken fillets", "Meat products", 3.00m, 3));   
        Items.Add(new Item("Potatoes", "Vegetables", 0.50m, 4));
        Items.Add(new Item("Tomatoes", "Vegetables", 0.80m, 5));
        Items.Add(new Item("Cheese", "Milk products", 2.10m, 6));
        Items.Add(new Item("Milk", "Milk products", 1.00m, 7));
        Items.Add(new Item("Bread", "Bakery", 1.20m, 8));
        Items.Add(new Item("Butter", "Milk products", 1.89m, 9));
        Items.Add(new Item("Tuna chunks", "Fish products", 2.99m, 10));
        Items.Add(new Item("Brandy", "Alcohol", 12.49m, 11));
        Items.Add(new Item("Visky", "Alcohol", 8.43m, 12));
        Items.Add(new Item("Beef", "Meat products", 4.59m, 13));
        Items.Add(new Item("Bananas", "Fruits", 0.89m, 14));
        Items.Add(new Item("Apples", "Fruits", 0.80m, 15));
        Items.Add(new Item("Cherries", "Fruits", 2.10m, 16));
        Items.Add(new Item("Beer", "Alcohol", 1.00m, 17));
        Items.Add(new Item("Coca-cola", "Drinks", 1.20m, 18));
        Items.Add(new Item("Fanta", "Drinks", 1.89m, 19));
        Items.Add(new Item("Sprite", "Drinks", 2.99m, 20));
    }

    public List<Item> Generate()                                                  //Generate() method generates a random list of orders from an 'Items' list
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
