using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("{0},{1}",i,i*i);
			}
			Console.ReadKey();
		}
	}
}
