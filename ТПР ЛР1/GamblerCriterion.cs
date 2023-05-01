using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public class AzartCriterion
    {
        public string Azart(ref int[,] table)
        {
            int[] max = new int[MainProgram.resh];
            Console.WriteLine("Maxes: ");
            for (int i = 0; i < MainProgram.resh; ++i)
            {
                max[i] = 0;
                for (int j = 0; j < MainProgram.sost; ++j)
                    max[i] = table[i, j] * Convert.ToInt32(table[i, j] >= max[i]) + max[i] * Convert.ToInt32(table[i, j] < max[i]);
                Console.WriteLine(max[i]);
                }
            string solves = "";
            for (int i = 0; i < MainProgram.resh; ++i)
                if (max[i] == max.Max())
                    solves+=(Convert.ToString(i+1)+" "); 
            return solves;
        }
    }
}
