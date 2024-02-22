using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string c = "";
			foreach (char s in str) 
			{
				c = s + c;
			}
			Console.WriteLine(c);
			Console.ReadLine();
		}
	}
}
