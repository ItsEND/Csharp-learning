﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number=Convert.ToInt32(Console.ReadLine());
			switch (number)
			{
				case 1:
					{
						Console.WriteLine("Пн");
						break;
					}
				case 2:
					{
						Console.WriteLine("Вт");
						break;
					}
				case 3:
					{
						Console.WriteLine("Ср");
						break;
					}
				case 4: 
					{
						Console.WriteLine("Чт");
						break;
					}
				case 5:
					{
					
						Console.WriteLine("Пт");
						break;
						
					}	
				case 6:
					{
						Console.WriteLine("Сб");
						break;
					}
				case 7:
					{
						Console.WriteLine("Вс");
						break;
					}
				default:
					{
						Console.WriteLine("Error");
						break;
					}
			}
			Console.ReadKey();
		}
	}
}
