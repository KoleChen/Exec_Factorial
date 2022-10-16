using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一個數字");
			int num = Convert.ToInt32(Console.ReadLine());
			int a = 1;
			for (int i = 1; i <= num; i++)
			{
				a = a * i;
			}
			Console.WriteLine(num + "!為" + a);
		}
	}
}
