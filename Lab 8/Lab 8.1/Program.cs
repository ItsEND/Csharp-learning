using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Выберете любую папку на своем компьютере имеющую вложенные директории
			Выведите на консоль все .txt файлы, содержащиеся в указанном каталоге или подкатологах
			*/
			string path = @"D:/Temp";
			string[] Deri = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
			foreach(string file in Deri)
			{
                Console.WriteLine(file);
            }
			Console.ReadKey();
		}
	}
}
