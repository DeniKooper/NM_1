using System;
using System.IO;
using Real = System.Double;

namespace NM_1
{
    class IO
    {
        string path;

        public IO(string path)
        {
            this.path = path;
        }

        public int InputNum(string fileName)
        {
            Console.WriteLine("Reading from {0} started...", fileName);
            FileStream file = new FileStream(path + fileName, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            int num = Convert.ToInt32(streamReader.ReadLine());
            streamReader.Close();
            Console.WriteLine("Reading complete!");
            return num;
        }

        public Real[] InputFile(string fileName, int size)
        {
            Console.WriteLine("Reading from {0} started...", fileName);
            FileStream file = new FileStream(path + fileName, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            Real[] data = new Real[size];
            for (int i = 0; i < size; i++)
                data[i] = Convert.ToDouble(streamReader.ReadLine());
            streamReader.Close();
            Console.WriteLine("Reading complete!");
            return data;
        }

        public Real[,] InputFile(string fileName, int n, int k)
        {
            Console.WriteLine("Reading from {0} started...", fileName);
            FileStream file = new FileStream(path + fileName, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            Real[,] data = new Real[n, k];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < k; j++)
                    data[i, j] = Convert.ToDouble(streamReader.ReadLine());
            streamReader.Close();
            Console.WriteLine("Reading complete!");
            return data;
        }

        public void OutputFile(string fileName, Real[] data)
        {
            Console.WriteLine("\n\\\\Saving the file with the result.");
            FileStream file = new FileStream(path + fileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(file);
            for (int i = 0; i < data.Length; i++)
                streamWriter.Write(data[i] + " ");
            streamWriter.Close();
            Console.WriteLine("Reading complete! File saved in this path:  " + path + fileName);
        }
    }
}
