using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_ReceiptGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();    // Creating new Methods class object 'methods' .
            methods.Printer();                  //Calling Printer() method from 'methods' .
        }    
    }
}



//Task is to create Receipt generator for orders. First we need to generate orders with some item-lists and price. 