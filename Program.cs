using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_ReceiptGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataPrinter dataPrinter = new DataPrinter();
            dataPrinter.PrintProductList();
            dataPrinter.PrintOrdersData();
        }    
    }
}
