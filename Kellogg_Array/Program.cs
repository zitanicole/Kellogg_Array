// Kellogg, Zita (Nicci)
// IT 113

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
			myArray.Add();
			myArray.showArray();
			sw.Stop();
			Console.WriteLine("\nElapsed Time: " + sw.Elapsed);
		}
	}
}