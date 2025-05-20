using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизм
{
    class Perimetr
    {
        public int P { get; set; }
        public string Name { get; set; }
        public virtual void Raschet()
        {
            Console.WriteLine(Name + "  -  " + P);
        }
        class Kvadrat : Perimetr
        {
            public int a;
            public override void Raschet()
            {
                P = 4 * a;
                Console.WriteLine(Name + "-" + P);
            }

        }
        class Primoygol : Perimetr
        {
            public int a;
            public int b;
            public override void Raschet()
            {
                P = 2 * (a + b);
                Console.WriteLine(Name + "-" + P);
            }

        }
        class Treygol : Perimetr
        {
            public int a;
            public int b;
            public int c;
            public override void Raschet()
            {
                P = a + b + c;
                Console.WriteLine(Name + "-" + P);
            }
        }
        class Trapecia : Perimetr
        {
            public int a;
            public int b;
            public int c;
            public override void Raschet()
            {
                P = a + b + 2 * c;
                Console.WriteLine(Name + "-" + P);

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Kvadrat kvadrat = new Kvadrat { Name = "Квадрат", a = 4 };
                kvadrat.Raschet();
                Primoygol primoygol = new Primoygol { Name = "Прямоугольник", a = 2, b = 6 };
                primoygol.Raschet();
                Treygol treygol = new Treygol { Name = "Треугольник", a = 1, b = 5, c = 4 };
                treygol.Raschet();
                Trapecia trapecia = new Trapecia { Name = "Трапеция", a = 4, b = 3, c = 5 };
                trapecia.Raschet();
            }
        }
    }
   
}
