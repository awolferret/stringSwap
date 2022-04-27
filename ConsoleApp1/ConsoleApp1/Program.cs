using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите любимое число");
            int favoritNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите худшее число");
            int worstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше любимое число {favoritNumber},худшим вы считаете = {worstNumber}");
            int bufferNumber;
            bufferNumber = favoritNumber;
            favoritNumber = worstNumber;
            worstNumber = bufferNumber;
            Console.WriteLine($"теперь ваше любимаое число {favoritNumber},худшим вы считаете {worstNumber}");
        }
    }
}
