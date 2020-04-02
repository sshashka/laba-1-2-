using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть чисельник та знаменник першого та другого дробу");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            sas a = new sas(a1, a2);
            sas b = new sas (b1, b2);
            a.Sokr();
            Console.WriteLine(a.a + " " + a.b);
            b.Sokr();
            Console.WriteLine(b.a + " " + b.b);
            if (a.eqvi(a, b))
                Console.WriteLine("eqv");
            else
                Console.WriteLine("n eqv");
            sas c = new sas();
            c.Dod(a, b);

            Console.WriteLine(a.a + " " + a.b);
            Console.WriteLine(b.a + " " + b.b);
            sas d = new sas();
            d.Dil(a, b);
            Console.WriteLine(a.a + " " + a.b);
            Console.WriteLine(b.a + " " + b.b);
            sas e = new sas();
            e.vidn(a, b);
            Console.WriteLine(a.a + " " + a.b);
            Console.WriteLine(b.a + " " + b.b);
            sas f = new sas();
            f.Mnoj(a, b);
            Console.WriteLine(a.a + " " + a.b);
            Console.WriteLine(b.a + " " + b.b);
            Console.WriteLine(c.a + " " + c.b  + " Додавання");
            Console.WriteLine(d.a + " " + d.b + " dil " );
            Console.WriteLine(e.a + " " + e.b + " Vidn");
            Console.WriteLine(f.a + " " + f.b + " Mnoj");

            Console.ReadKey();

        }
    }
}
