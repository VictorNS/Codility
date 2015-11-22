using System;

namespace _0_MinPerimeterRectangle
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(solution(3 * 5));
			Console.WriteLine(solution(3 * 11));
		}

		static int solution(int N)
		{
			var sqrt = Math.Sqrt(N);
			var cand = (int)sqrt;
			var n1 = cand;
			while (N % n1 != 0)
			{
				n1--;
			}
			var n2 = N / n1;

			Console.WriteLine("N {4}    sqrt {0} cand {1}    n1 {2} n2 {3}", sqrt, cand, n1, n2, N);

			return (n1 + n2) * 2;
		}
	}
}
