using System;
public class InventoryItem
{
    // Properties

    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        QuantityInStock -= quantitySold;
        if (QuantityInStock < 0)
        {
            QuantityInStock = 0; // Ensures stock doesn't go negative
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item Name: {ItemName}, ID: {ItemId}, Price: ${Price}, Stock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Initial details of items:");
        item1.PrintDetails();
        item2.PrintDetails();
        // 2. Sell some items and then print the updated details.
        item1.SellItem(1); // Selling 1 Laptop
        item2.SellItem(3); // Selling 3 Smartphones
        Console.WriteLine("\nDetails after selling some items:");
        item1.PrintDetails();
        item2.PrintDetails();
        // 3. Restock an item and print the updated details.
        item1.RestockItem(5); // Restocking 5 Laptops
        Console.WriteLine("\nDetails after restocking laptops:");
        item1.PrintDetails();
        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("\nStock status:");
        Console.WriteLine(item1.ItemName + " is " + (item1.IsInStock() ? "in stock." : "out of stock."));
        Console.WriteLine(item2.ItemName + " is " + (item2.IsInStock() ? "in stock." : "out of stock."));


    }
}