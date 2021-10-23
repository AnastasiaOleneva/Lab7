using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 13;
            int b1 = 14;
            int c1 = 17;
            int a2 = 10;
            int b2 = 13;
            int c2 = 16;
            double P1, S1,P2,S2;
            compare_triangle(a1, b1, c1,out P1,out S1,a2,b2,c2,out P2,out S2);
            Console.ReadKey();

        }

       static void compare_triangle(int a1, int b1, int c1, out double P1, out double S1,int a2,int b2,int c2,out double P2,out double S2) 
        {

            P1 = (a1 + b1 + c1)/2;
            S1 = Math.Sqrt(P1 * (P1 - a1) * (P1 - b1) * (P1 - c1));
            P2 = (a2 + b2 + c2)/2;
            S2 = Math.Sqrt(P2 * (P2 - a2) * (P2 - b2) * (P2 - c2));
           
            if (S1>S2)
            {
                Console.WriteLine("Площадь первого треугольника S1={0:0.00} со сторонами a1={1}, b1 ={2}, c1={3} больше площади второго S2={4:0.00}", S1,a1,b1,c1,S2);
            }
            else 
            {
                Console.WriteLine("Площадь второго треугольника S2={0:0.00} со сторонами a2={1}, b3 ={2}, c4={3} больше площади первого {S1:0.00}" , S2, a2, b2, c2,S1);
            }
            Console.ReadKey();
        }
    }
}
