using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal Sum = 1000;
			decimal Sum2=Sum*2;
			decimal p = 4;
			int year = 0;
			while (Sum < Sum2)
			{
				Sum += Sum * 4 / 100;
				year++;
			}
			Console.WriteLine(year);	
			Console.ReadKey();
		}
	}
}
