using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public  class BayesLaplaceCriterion
    {
        public float MaxSum(ref int[,] table)
        {
            int[] sum = new int[table.GetLength(0)];
            for (int i = 0; i < table.GetLength(0); ++i)
            {
                sum[i] = 0;
                for (int j = 0; j < table.GetLength(1); ++j)
                    sum[i] += table[i, j];
                sum[i] /= table.GetLength(1);
            }
            return sum.Max();
        }
    }
}
