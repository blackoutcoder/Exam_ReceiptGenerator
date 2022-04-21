using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;




public class Serializer
    
{
    public List<Order> orders;
	public void Serialize(List<Order> orders, string chosenFileName)
    {
        string path = @"C:\Users\romka\Documents\vigi15\Output for C#\" ;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        //Console.WriteLine(">Enter a file name without 'extention' to save report and press ENTER...");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        //string fileName = Console.ReadLine();
       
        string fileName = chosenFileName;
        var options = new JsonSerializerOptions { WriteIndented = true };
        //string text = JsonSerializer.Serialize(orders[lastOrder], options);                           //Test
        string text = JsonSerializer.Serialize(orders, options);
        
        File.WriteAllText(@$"{path}{fileName}.json", text);
        File.WriteAllText(@$"{path}{fileName}.txt", text);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($">Files ");
        Console.ForegroundColor= ConsoleColor.DarkRed;
        Console.Write($"{fileName}.json");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" and ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"{fileName}.txt");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" created successfully.");
        Console.Write($">Output directory: ");
        Console.ForegroundColor= ConsoleColor.DarkYellow;
        Console.WriteLine($"{path}");
        Console.WriteLine();
        Console.ResetColor(); 
        Console.Clear();
    }

}
