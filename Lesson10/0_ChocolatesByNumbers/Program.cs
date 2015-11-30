using System;

namespace _0_ChocolatesByNumbers
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(solution(10, 4));
			Console.WriteLine(solution(947853, 4453));
		}

		public static int solution(int N, int M)
		{
			var divider = gcd(N, M);
			return N / divider;
		}

		public static int gcd(int a, int b)
		{
			if (a % b == 0)
				return b;
			return gcd(b, a % b);
		}

	}
}
