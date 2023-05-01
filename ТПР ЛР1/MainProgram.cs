using System;

namespace ТПР_ЛР1
{
    public class MainProgram
    {
        public static int resh = 10, sost = 14;
        public static void Main()
        {
            int[,] table = new int[resh, sost];
            Creation(ref table);

            AzartCriterion Obj1 = new AzartCriterion();
            Console.WriteLine($"Best choice by Risk Criterion is: {Obj1.Azart(ref table)}");
            HurwitzCriterion Obj2 = new HurwitzCriterion();
            Console.WriteLine($"\nBest choice by Hurwit's Criterion is: {Obj2.Hurwitz(ref table)}");
            Console.ReadKey();
        }
        public static void Creation(ref int[,] table)
        {
            Random rnd = new Random();
            for (int i = 0; i < resh; ++i)
                for (int j = 0; j < sost; ++j)
                    table[i, j] = rnd.Next() % 100;
            for (int i = 0; i < resh; ++i)
            {
                for (int j = 0; j < sost; ++j)
                    Console.Write($"{table[i, j], 3} ");
                Console.WriteLine();
            }

        }
    }
}
