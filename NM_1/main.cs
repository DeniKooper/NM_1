using System;
using System.Collections.Generic;
using System.Collections;
using Real = System.Double;

namespace NM_1
{
    class main
    {
        static void Main(string[] args)
        {
            IO IO = new IO("C:\\Users\\Kuhti\\source\\repos\\NM_1\\NM_1\\");
            Real[,] line;
            Real[] di, v, result;
            int n, k;
            n = IO.InputNum("n.txt");
            k = IO.InputNum("k.txt");
            di = IO.InputFile("di.txt", n);
            line = IO.InputFile("line.txt", n, k);
            v = IO.InputFile("v.txt", n);
            result = new Real[n];

            LCalc(di, line, v, n, k);
            YCalc(di, line, v, n, k);
            XCalc(di, line, v, n, k);

            Console.ReadKey();
        }

        static void LCalc(Real[] di, Real[,] line, Real[] v, int n, int k)
        {
            double sum = 0, diSum = 0;
            int q = 0;
            int[] R = new int[n];
            R[0] = k;
            for (int i = 1; i < k; i++)
                R[i] = R[i - 1] - 1;
            for (int i = 0; i < n; i++)
            {
                if (i > k) q++;
                for (int j = R[i]; j < k; j++)
                {
                    for (int t = 0; t < j - R[i]; t++)
                        sum += line[i, R[i] + t] * line[j - R[i]+q, R[j - R[i]] + t];
                    line[i, j] = (line[i, j] - sum) / di[j - R[i] + q];
                    sum = 0;
                    diSum += line[i, j] * line[i, j];
                }
                di[i] = Math.Sqrt(di[i] - diSum);
                diSum = 0;
            }
        }
        static void YCalc(Real[] di, Real[,] line, Real[] v, int n, int k)
        {
            double sum = 0;
            int j, m;
            for (int i = 0; i < n; i++)
            {
                j = i - k;
                if (j < 0)
                {
                    m = k - i;
                    j = 0;
                }
                else m = 0;
                for (; m < k; j++, m++)
                    sum += line[i, m] * v[j];
                v[i] = (v[i] - sum) / di[i];
                sum = 0;
            }
        }

        static void XCalc(Real[] di, Real[,] line, Real[] v, int n, int k)
        {
            double sum = 0;
            int j, m, q, t, h;
            h = -1;
            t = k + 1;
            for (int i = n - 1; i >= 0; i--)
            {
                j = n - i;
                if (n - k > j - 2) // -2  или k-1
                {
                    t--;
                    q = n - 1;
                } else
                {
                    h--;
                    q = n + h; ;
                }
                for (m = t; m < k; j--, m++, q--)
                    sum += line[q, m] * v[q];
                v[i] = (v[i] - sum) / di[i];
                sum = 0;
            }
        }

        static  Real[] multiple(Real[] di, Real[,] line, Real[] v, int n, int k, Real[] res)
        { 
            for (int i = 0; i < k; i++)
                for (int j = 0, m = k - i; j < n; j++)
                {
                    res[j] += line[j, i] * v[j];
                    if (j < n - m)
                        res[j] += line[m, i] * v[j];
                }
            for (int i = 0; i < n; i++) 
                res[i] += di[i] * v[i];
            return res;
        }

        static Real[] multipleN(Real[] di, Real[,] line, Real[] v, int n, int k, Real[] res)
        {
            int m, j = 0;
            for (int i = 0; i < n; i++)
            {
                res[i] += di[i] * v[i];
                m = i - k;
                if (m < 0) continue;
                for (; j < k; j++, m++)
                {
                    res[i] += line[i, j] * v[m];
                    res[m] += line[m, j] * v[i];
                }
                j = 0;
            }
            return res;
        }
    }
}
