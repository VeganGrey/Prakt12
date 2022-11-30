using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPoPrikoly
{
    public class rabotka
    {
        public void PerPloshTr(double x1, double y1, double x2, double y2, double x3, double y3, out double Perim, out double Plosh)
        {
            double stA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double stB = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double stC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            Perim = stA + stB + stC;
            double p = 0;
            p = (stA + stB + stC) / 2;
            Plosh = Math.Sqrt(p * (p - stA) * (p - stB) * (p - stC));
        }

        public int ChisloSum(int chis)
        {
            int a, b, c;
            a = chis / 100;
            b = (chis / 10) % 10;
            c = chis % 10;
            int summ = a + b + c;
            return summ;
        }
        public int ChisloProizv(int chis)
        {
            int a, b, c;
            a = chis / 100;
            b = (chis / 10) % 10;
            c = chis % 10;
            int proizv = a * b * c;
            return proizv;
        }
    }
}