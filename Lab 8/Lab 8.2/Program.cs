using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 Програмно создайте текстовый файл и запишите в него 10 случайных чисел
			Затем программно откройте созданный файл, расчитайте количество положительных чисел в нем, ответ выведите на консоль.
			 */
			string path = @"D:\Temp\numbers.txt";
			Random random = new Random();
			int k = 0;
			using (StreamWriter sw = new StreamWriter(path, false))
			{
				for (int i = 0; i<10; i++)
				{
					sw.WriteLine(random.Next(-10, 10));
				}
			}
			using (StreamReader sr = new StreamReader(path))
			{
				for (int i = 0; i < 10; i++)
				{
					if (Convert.ToInt32(sr.ReadLine()) > 0)
					{
						k++;
					}
				}
			}
            Console.WriteLine(k);
			Console.ReadKey();
        }
	}
}
