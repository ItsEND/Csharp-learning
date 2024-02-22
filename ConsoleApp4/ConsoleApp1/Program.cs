using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static double GettHyp(double a, double b)
		{
			return Math.Sqrt(a * a + b * b);
		}

		static void Main(string[] args)
		{
            Console.WriteLine("Введите катеты первого триугольника");
			double firstA = Convert.ToDouble(Console.ReadLine());
			double firstB = Convert.ToDouble(Console.ReadLine());
			double Hyp1=GettHyp(firstA, firstB);
            Console.WriteLine("Введите катеты второго триугольника");
			double secondA=Convert.ToDouble(Console.ReadLine());
			double secondB=Convert.ToDouble(Console.ReadLine());
			double Hyp2 = GettHyp(secondA, secondB);
			if (Hyp1 > Hyp2)
			{
                Console.WriteLine(Hyp1);
            }
			else
			{
                Console.WriteLine(Hyp2);
            }
        }
	}
}
