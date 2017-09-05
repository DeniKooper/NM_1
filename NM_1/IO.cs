using System.IO;
using System.Collections;
using System;

namespace NM_1
{
    class IO
    {
        public double[] readFile(string fileName, int n)
        {
            FileStream file = new FileStream("../../" + fileName, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            double[] input = new double[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = System.Convert.ToDouble(reader.ReadLine());
            }

            reader.Close();
            return input;
        }

        public int readSize(string fileName, int n)
        {
            int Result;
            FileStream file = new FileStream("../../" + fileName, FileMode.Open);
            StreamReader reader = new StreamReader(file);

            Result = System.Convert.ToInt32(reader.ReadToEnd().Split('\n')[n]);

            reader.Close();
            return Result;
        }

        public void writeResult(double[] result, int n)
        {
            FileStream file = new FileStream("../../out.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            writer.Write("Result is: ");
            for (int i = 0; i < n; i++)
            {
                writer.Write(result[i] + " ");
            }
            
            writer.Close();
        }
    }
}
