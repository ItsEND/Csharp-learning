﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string[] strArray = str.Split();
			string min = strArray[0];
			
			foreach (string s in strArray)
			{
				if (s.Length < min.Length)
				{
					min = s;
				}
			}

			Console.WriteLine(min);
            Console.ReadLine();
        }
	}
}