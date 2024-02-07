using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 4 };
			foreach (int a in array)
			{
				Console.WriteLine(a);	
			}
			Console.ReadKey();

		}
	}
}
