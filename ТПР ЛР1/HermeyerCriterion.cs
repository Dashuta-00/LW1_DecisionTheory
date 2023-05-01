using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТПР_ЛР1
{
    public class HermeyerCriterion
    {
        public float MinM(ref int[,] table)
        {
            float[] min = new float[MainProgram.sost];
            for (int i = 0; i < MainProgram.resh; ++i)
            {
                min[i] = 0;
                for (int j = 0; j < MainProgram.sost; ++j)
                    min[i]= Convert.ToInt32(table[i, j] < min[i]) * table[i, j] + Convert.ToInt32(table[i, j] >= min[i]) * min[i];
                min[i] /= MainProgram.sost;
            }
            return min.Max();
        }
    }
}
