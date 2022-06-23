using System;
using System.Collections.Generic;
using System.Linq;

namespace metprgEgzamin1
{
    class Program
    {
        static int step = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Ile elementów?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Max element?");
            int max = int.Parse(Console.ReadLine());
            List<int> elementList = new List<int>();
            Random random = new Random();
            for(int i=0;i<count; i++)
            {
                elementList.Add(random.Next(max));
            }
            CutList(elementList);
            Console.ReadKey();
        }
        static List<int> CutList(List<int> elementList)
        {
            ShowList(elementList);
            if (elementList.Count == 1) return null;
            else
            {
                int a = elementList.Max();
                elementList.Remove(a);
                int b = elementList.Max();
                elementList.Remove(b);
                elementList.Add(a + b);
                Console.ReadKey();
                return CutList(elementList);
            }
        }
        static void ShowList(List<int> elementList)
        {
            Console.Write($"Krok {step}\t");
            foreach(int element in elementList)
            {
                Console.Write($"{element}\t");
            }
            step++;
            Console.WriteLine();
        }
    }
}
