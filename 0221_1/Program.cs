using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0221_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串，並將其反向顯示");           
            var result = Console.ReadLine().Split(',').Reverse();
            Console.WriteLine($"Reverse結果:{string.Join(",", result)}");
            Console.ReadKey();
        }
    }
}
