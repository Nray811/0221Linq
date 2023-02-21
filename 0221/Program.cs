using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0221_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串\n將其依照奇偶數分割為兩個數列，並且予以排序顯示結果");
            var s = Console.ReadLine().Split(',');
            var even = s.Where(x => int.Parse(x) % 2 == 0).OrderBy(x => int.Parse(x));
            var odd = s.Where(  x => int.Parse(x) % 2 == 1).OrderBy(x => int.Parse(x));             
            Console.WriteLine($"奇數.Orderby結果:{string.Join(",", odd )}");                     
            Console.WriteLine($"偶數.Orderby結果:{string.Join(",", even)}");        
            Console.ReadKey();


        }
    }
}
