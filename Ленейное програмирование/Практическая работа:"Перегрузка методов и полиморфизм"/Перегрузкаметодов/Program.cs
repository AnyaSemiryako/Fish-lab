using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузкаметодов
{
    internal class Program
    {
        class Perimetr
        {
            public void Raschet(int a)
            {
                int P;
                P = 4 * a;
                Console.WriteLine("Периметр квадрата с стороной "+a+"равен :" + P);
            }
            public void Raschet(int a, int b)
            {
                int P;
                P = 2 * (a + b);
                Console.WriteLine("Периметр прямоугольника "+a+" на "+b+":" + P);
            }
            public void Raschet(int a, int b, int c)
            {
                int P;
                P = a + b + c;
                Console.WriteLine("Периметр прямоугольного треугольника:" + P);
            }
            public void Raschet(int a, int b, int c, int two)
            {
                int P;
                two = 2;
                P = a + b + two * c;
                Console.WriteLine("Периметр трапеции" + ":" + P);
            }
        }
        class Peregrev
        {
            static void Main(string[] args)
            {
                Perimetr perimetr = new Perimetr();
                perimetr.Raschet(6);
                perimetr.Raschet(2, 4, 8);
                perimetr.Raschet(4, 9);
                perimetr.Raschet(2, 2,4);

            }
        }
    }
    }
}
