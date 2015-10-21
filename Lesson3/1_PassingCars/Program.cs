using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_PassingCars
{
	class Program
	{
		static void Main()
		{
			var A = new int[5];
			A[0] = 0;
			A[1] = 1;
			A[2] = 0;
			A[3] = 1;
			A[4] = 1;
			Console.WriteLine("Result: {0}", solution(A));

			A[0] = 0;
			A[1] = 0;
			A[2] = 0;
			A[3] = 0;
			A[4] = 0;
			Console.WriteLine("Result: {0}", solution(A));

			A[0] = 1;
			A[1] = 1;
			A[2] = 1;
			A[3] = 1;
			A[4] = 1;
			Console.WriteLine("Result: {0}", solution(A));

			A = new int[2];
			A[0] = 0;
			A[1] = 1;
			Console.WriteLine("Result: {0}", solution(A));

			A[0] = 1;
			A[1] = 0;
			Console.WriteLine("Result: {0}", solution(A));
		}

		static int solution(int[] A)
		{
			var arrLength = A.Length;
			int[] counting = new int[arrLength];
			int accumulator = 0;
			for (int i = 0; i < arrLength; i++)
			{
				accumulator += A[i];
				counting[i] = accumulator;
				Console.WriteLine("  {0} = {1} counting: {2}", i, A[i], accumulator);
			}
			if (accumulator == 0)
			{
				Console.WriteLine("  accumulator = {0} => exit", accumulator);
				return 0;
			}
			var arithmeticalProgression = (counting[0] + counting[arrLength - 1]) * arrLength / 2;
			if (accumulator == arithmeticalProgression && counting[0] == 1)
			{
				Console.WriteLine("  accumulator = {0} => exit", accumulator);
				return 0;
			}
			accumulator = 0;
			for (int i = 0; i < arrLength; i++)
			{
				if (A[i] == 0)
				{
					var res = counting[arrLength - 1] - counting[i];
					if (res + accumulator > 1000000000)
						return -1;
					accumulator += res;
					Console.WriteLine("  count from {0} to the end: {1}", i, res);
				}
			}
			return accumulator;
		}
	}
}
