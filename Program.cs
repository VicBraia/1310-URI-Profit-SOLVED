using System;
using System.Linq;

namespace Lucro
{
    class Program
    {
        public static int n, days, costPerDay, revenue, resp;
        public static string line;
        public static int[] profitPerDay = new int[50];
        public static int[] aux = new int[50];

        public static void CalcMaxProfit()
        {
            aux[0] = Math.Max(0, profitPerDay[0]);

            for (int i = 1; i < days; i++)
            {
                aux[i] = Math.Max(profitPerDay[i] + aux[i - 1], Math.Max(0, profitPerDay[i]));
            }
            resp = aux.Max();
        }

        static void Main(string[] args)
        {
            while ((line = Console.ReadLine()) != null)
            {
                days = int.Parse(line);
                costPerDay = int.Parse(Console.ReadLine());

                for (int i = 0; i < days; i++)
                {
                    revenue = int.Parse(Console.ReadLine());
                    profitPerDay[i] = revenue - costPerDay;
                }

                CalcMaxProfit();
                Console.WriteLine(resp);
                Array.Clear(profitPerDay, 0, profitPerDay.Length);
                Array.Clear(aux, 0, aux.Length);
            }
        }
    }
}
