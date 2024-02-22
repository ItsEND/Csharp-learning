using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void GetParamsSphere(double r,out double S, out double V)
		{
			S = 4 * Math.PI * r * r;
			V = 4.0 / 3 * Math.PI * r * r * r;
		}
		static void Main(string[] args)
		{
            Console.WriteLine("Радиус");
			double r=Convert.ToInt32(Console.ReadLine());
			double S;
			double V;
			GetParamsSphere(r,out S,out V);
			Console.WriteLine("Площадь равна {0:.00} объем равен {1:.00}", S, V);
			Console.ReadKey();
        }
	}
}
