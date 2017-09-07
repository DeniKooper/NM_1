using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace NM_1
{
    class main
    {
        static void Main(string[] args)
        {
            IO helper = new IO();
            int n = helper.readSize("n.txt", 0);
            int k = helper.readSize("n.txt", 1);
            double[] line = helper.readFile("line.txt", n * (2*k +1));
            double[] v = helper.readFile("v.txt", n);
            mult M = new mult();
            double[] result = M.multiple(line, v, n, k);
            helper.writeResult(result, n);
        }
    }
}
