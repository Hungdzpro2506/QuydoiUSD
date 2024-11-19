using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        const double rate = 23000.0;

       
        Console.Write("Nhập giá trị USD: ");
        double usdValue = double.Parse(Console.ReadLine());

        
        double vndValue = usdValue * rate;
        Console.WriteLine($"{usdValue} USD = {vndValue} VND");
        }
    }
}
