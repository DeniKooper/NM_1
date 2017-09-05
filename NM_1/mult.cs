using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM_1
{
    class mult
    {
        public double[] multiple(double[] di, double[] au, double[] ad, double[] v, int n, int k)
        {
            double[] result = new double[n];
            int t = 0;

            for(int i = 0; i < n; i++)
            {
                result[i] = v[i] * di[i];
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = k-t; j < k; j++)
                {
                    result[i] += v[i] * ad[i * k + j];
                    result[i] += v[i] * au[i * k + j];
                }
                t++;
            }



            for (int i = k; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    result[i] += v[i] * ad[i * k + j];
                    result[i] += v[i] * au[i * k + j];
                }
            }

            return result;
        }
    }
}
