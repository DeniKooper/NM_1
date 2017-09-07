using System;
using System.Collections.Generic;

namespace NM_1
{
    class mult
    {
        public double[] multiple(double[] line, double[] v, int n, int k)
        {
            double[] result = new double[n];
            int m = 2 * k + 1;
            int t = 0;

            for (int i = 0; i < k; i++)
            {
                t = k - i;
                for (int j = 0; j < k + i + 1; j++)
                    result[i] += line[i*m + t + j] * v[j];
            }
            t = 0;
            for (int i = n - k; i < n; i++)
            {
                for (int j = 0; j < m - t - 1; j++)
                    result[i] += line[i*m + j] * v[m - k + t + j - 2];
                t++;
            }
            for (int i = k; i < n - k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i] += line[i*m + j] * v[i - k + j];
                }
            }

            return result;
        }
    }
}
