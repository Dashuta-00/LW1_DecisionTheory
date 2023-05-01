using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public class SavageCriterion
    {
        public static int[] MaxInColumn(ref int[,] table)
        {
            int max = -1;
            int[] temp = new int[MainProgram.sost];
            for (int j = 0; j < MainProgram.sost; j++)
                for (int i = 0; i < MainProgram.resh; i++)
                    temp[j] = Convert.ToInt32(table[i, j] > max) * table[i, j] + Convert.ToInt32(table[i, j] <= max) * max;
            return temp;
        }
        public static int MaxDiff(ref int[,] table)
        {
            int[,] maxes = new int[MainProgram.resh, MainProgram.sost];

            for (int j = 0; j < MainProgram.sost; ++j)
            {
                for (int i = 0; i < MainProgram.resh; ++i)
                    maxes[i, j] = MaxInColumn(ref table)[j] - table[i, j];
            }
            int[] result_maxes = new int[MainProgram.sost]  ;
            for (int i=0; i < MainProgram.sost; ++i)
            {
                for (int j = 0; j < MainProgram.resh; ++j)
                    result_maxes[i] = Convert.ToInt32(result_maxes[i] < maxes[i, j]) * maxes[i,j]+ Convert.ToInt32(result_maxes[i] >= maxes[i, j]) * result_maxes[i];
            }
            return result_maxes.Min();

        }

    }
}
