using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numarray = new List<int>{ 1, 4, 3, 88, 55, 454, 23, 33, 66, 86 };
			Func<int, bool> IsEven = n => n % 2 == 0;
			List<int> result = GetEvenitems(numarray,IsEven);
			foreach (int item in result)
			{
				Console.WriteLine(item);
			}
		}
		static List<int> GetEvenitems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();
			foreach (int item in source)
			{
				if (func(item) == true)
				{
					result.Add(item);
				}
			}
			return result;
		}
	}
	
}
