using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ваше число-{num}");
            }
            catch(FormatException)
            {
                Console.WriteLine($"Не верный формат");
            }
            finally
            {

            }
            Console.ReadLine();
        }
    }
}
