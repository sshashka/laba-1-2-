using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_2_
{
    class sas
    {
        public int a;
        public int b;
        public void prav()
        {
            if (a < b)
            {
                Console.WriteLine("prav");
            }
            else
            {
                Console.WriteLine("NePrav");
            }
        }

        private int normal(int p, int q)
        {
            int x, y, NOD;
            x = Math.Abs(p);
            y = Math.Abs(q);
            while (Math.Abs(x) != Math.Abs(y))
            {
              
                if (x > y)
                    x = x - y;
                else y = y - x;
            }
            NOD = x;
            return x;
        }

        public void Sokr()
        {
            int j = normal(a, b);
            a = a / j;
            b = b / j;
        }

        public sas()
        {

        }

        public sas(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public bool eqvi(sas d1, sas d2)
        {
            sas d3 = d1;
            sas d4 = d2;
            d4.Sokr();
            d3.Sokr();
            if (d3.a == d4.a && d3.b == d4.b)
            {
                return true;
            }
            return false;
        }
        public void Dod(sas d3, sas d4)
        {
            d4.Sokr();
            d3.Sokr();
            this.a = d3.a * d4.b + d4.a * d3.b;
            this.b = d3.b * d4.b;             
        }

        public void vidn(sas d3, sas d4)
        {
            d4.Sokr();
            d3.Sokr();
            this.a = d3.a * d4.b - d4.a * d3.b;
            this.b = d3.b * d4.b;   
        }

        public void Mnoj(sas d3, sas d4)
        {
            d4.Sokr();
            d3.Sokr();
            this.a = d3.a *d4.a;
            this.b = d3.b * d4.b;   
        }

        public void Dil(sas d3, sas d4)
        {
            d4.Sokr();
            d3.Sokr();
            this.a = d3.a * d4.b;+
            this.b = d4.a * d3.b;      
        }
    }
}
