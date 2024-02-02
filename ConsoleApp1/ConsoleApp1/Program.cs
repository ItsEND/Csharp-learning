using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double R = Convert.ToDouble(Console.ReadLine());
			double V = ((double)4) / 3 * (Math.PI * Math.Pow(R,3));
			Console.WriteLine(V);
			Console.ReadKey();
		}
	}
}
