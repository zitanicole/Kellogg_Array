using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kellogg_Array
{
	internal class CharArray<T>
	{
		private List<T> list;
		private Random random;
		public CharArray() 
		{
			list = new List<T>();
			random = new Random();
		}	
		public void Add()
		{
			for (char c = 'A'; c <= 'Z' && list.Count <50; c++) 
			{
				list.Add((T)(object)c);
			}
			for (char c = 'a'; c <= 'z' && list.Count<50; c++)
			{
				list.Add((T)(object)c);
			}
		}
		public void Shuffle()
		{
			int n = list.Count;
			while(n > 1)
			{
				n--;
				int k = random.Next(n+1);	
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public void showArray()
		{
			Shuffle();
			Console.WriteLine("50 element, alphabetical (unique by case) character array:");
			foreach (T item in list) 
			{
				Console.Write(item + "\n");
			}
		}
	}
}