using System;
using System.Collections.Generic;

namespace Exam_ReceiptGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa pasileidžia...");
            Console.WriteLine();
            ItemRepository itemRep = new ItemRepository();
            List<Item> itemsList = itemRep.Retrieve();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Turimų prekių sąrašas:");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.WriteLine(itemsList[i].ItemName);
                Console.WriteLine(itemsList[i].ItemDescription);
            }
        }
    }
}
