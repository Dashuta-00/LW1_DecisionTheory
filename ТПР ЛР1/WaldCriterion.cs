using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public class WaldCriterion
    {
        public int MinMax(int[,] table)
        {
            int[] min = new int[MainProgram.resh];
            for (int i = 0; i < MainProgram.resh; ++i)
            {
                min[i] = 0;
                for (int j = 0; j < MainProgram.sost; ++j)
                    min[i] = Convert.ToInt32(table[i, j] < min[i]) * table[i, j] + Convert.ToInt32(table[i, j] >= min[i]) * min[i];
            }
            return min.Max();
        }
    }
}
