using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Ebob için iki tamsayıyı giriniz");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write(fonk(x, y));
            Console.ReadLine();
        }
        static int fonk(int x, int y)
        {
            if (x % y == 0)
                return y;
            else
                return (fonk(y,x % y));
        
        
        
        }
    }
}
