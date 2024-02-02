using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a= Convert.ToInt32(Console.ReadLine());
			int o = a % 10;
			if (10 < a % 100 && a % 100 < 20)
			{
				Console.WriteLine("Мы нашли {0} грибов", a);
			}
			else
			{
				switch (o)
				{
					case 1:
						Console.WriteLine("Мы нашли {0} гриб", a);
						break;
					case 4:
					case 2:
					case 3:
						Console.WriteLine("Мы нашли {0} гриба", a);
						break;
					default:
						Console.WriteLine("Мы нашли {0} грибов", a);
						break;
				}
			}
			Console.ReadKey();
			
			
		}	
	}
}
