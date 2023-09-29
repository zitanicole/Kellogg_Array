using System.Diagnostics;

namespace Kellogg_Array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			CharArray<char> myArray = new CharArray<char>();
			for (char c = 'A'; c <= 'Z'; c++) 
			{
				myArray.Add(c);
			}
			for (char c = 'a'; c <= 'z'; c++)
			{
				myArray.Add(c);
			}

			myArray.showArray();
			sw.Stop();
			Console.WriteLine("\nElapsed Time: " + sw.Elapsed);
		}
	}
}