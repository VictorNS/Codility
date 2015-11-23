using System;

namespace _1_CountFactors
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(solution(24));
			Console.WriteLine(solution(36));
		}

		public static int solution(int N)
		{
			Console.WriteLine(N);
			var res = 0;
			var number = 1;
			while (number * number < N)
			{
				if (N % number == 0)
				{
					res = res + 2;
					Console.Write("{0} ", number);
				}
				number++;
			}
			if (number * number == N)
			{
				res++;
				Console.Write("  {0}", number);
			}
			Console.WriteLine();
			return res;
		}
	}
}
