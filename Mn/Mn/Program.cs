using System;
using System.Diagnostics;

namespace Mn
{
	class Program
	{
		static double MnRecursive(int n)
		{
			double M0 = 1.0;
			double M1 = -3.0 / 4;
			double M2 = 1.5;

			if (n == 0)
			{
				return M0;
			}
			if (n == 1)
			{
				return M1;
			}
			if (n == 2)
			{
				return M2;
			}

			return MnRecursive(n - 3) + 1.0 / 2 * MnRecursive(n - 2) - 5.0 / 4 * MnRecursive(n - 1);
		}

		static double MnIterative(int n)
		{
			double M0 = 1.0;
			double M1 = -3.0 / 4;
			double M2 = 1.5;

			if (n == 0)
			{
				return M0;
			}
			if (n == 1)
			{
				return M1;
			}
			if (n == 2)
			{
				return M2;
			}

			double result = 0 ;
			
			for (int i = 3; i <= n; i++)
			{
				result = M0 + 1.0 / 2 * M1 - 5.0 / 4 * M2;
				M0 = M1;
				M1 = M2;
				M2 = result;
			}

			return result;
		}

		static void Main(string[] args)
		{
			Stopwatch sw = new Stopwatch();

			sw.Start();
			Console.WriteLine(MnRecursive(33));
			Console.WriteLine(sw.Elapsed);

			sw.Reset();
			sw.Start();

			Console.WriteLine(MnIterative(33));
			Console.WriteLine(sw.Elapsed);

			Console.WriteLine();
		}
	}
}