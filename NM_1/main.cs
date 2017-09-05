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
            double[] di = helper.readFile("di.txt", n);
            double[] au = helper.readFile("au.txt", n*k);
            double[] ad = helper.readFile("ad.txt", n*k);
            double[] v = helper.readFile("v.txt", n);
            mult M = new mult();
            double[] result = M.multiple(di, au, ad, v, n, k);
            helper.writeResult(result, n);
        }
    }
}
