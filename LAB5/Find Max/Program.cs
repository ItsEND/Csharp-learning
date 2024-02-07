using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Max
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[10];
			int max = array[0];
			int c = 0;
			Random random = new Random();
			for (int i = 0; i< 10; i++)
			{
				array[i] = random.Next();
				
			}
			Console.WriteLine();
			foreach (int a in array)
			{
				if (a > max)
				{
					max = a;
					c++;
				}
			}
			Console.WriteLine(max);
			Console.WriteLine(c);
			Console.ReadLine();
		}
	}
}
