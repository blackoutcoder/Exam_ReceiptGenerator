using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Serializer
    
{
	public void Serialize(List<Order> orders)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string text = JsonSerializer.Serialize(orders, options);
        File.WriteAllText(@"C:\Users\romka\Documents\vigi15\Output for C#\ReceiptList.json", text);
        File.WriteAllText(@$"C:\Users\romka\Documents\vigi15\Output for C#\ReceiptList.txt", text);
    }
}
