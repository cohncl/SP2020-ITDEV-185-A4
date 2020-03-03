using System;

namespace YieldExample
{
    class Program
    {
        static System.Collections.Generic.IEnumerable<int> GetList(int count)
        {
            // Fill item with int value
            for (int i = 1; i < count + 1; i++)
                yield return i;
        }
        static void Main(string[] args)
        {
            int l = 0;
            Console.WriteLine("How many items do you want in your list?");
            int x = Convert.ToInt32(Console.ReadLine());

            foreach (var item in GetList(x))
            {
                l++;
                Console.WriteLine($"item {l} = " + item.ToString());
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
