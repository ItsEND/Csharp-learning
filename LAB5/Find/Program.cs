using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[10];
			bool f=false;
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				array[i] = random.Next(0, 10);
				Console.Write("{0} ", array[i]);
			}
			foreach (int a in array)
			{
				if (a == 0)
				{
					Console.WriteLine("0 найден");
					f=true;
					break;
				}
				
			}
			if (f == false)
			{
				Console.WriteLine("Элемент не найден");
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
