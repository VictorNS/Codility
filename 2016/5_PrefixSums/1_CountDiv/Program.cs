using System;

namespace _1_CountDiv
{
	class Program
	{
		static void Main()
		{
			Run(0, 0, 11);
			Run(0, 1, 11);
			Run(1, 1, 11);
			Run(1, int.MaxValue, 1);
			Run(1, int.MaxValue, int.MaxValue);

			Run(0, 0, 1);
			Run(0, 0, 2000000000);
			Run(0, 1, 1);
			Run(0, 1, 2000000000);
			Run(0, 2000000000, 1);
			Run(0, 2000000000, 2000000000);
			Run(1, 2000000000, 1);
			Run(1, 2000000000, 2000000000);
			Run(2000000000, 2000000000, 1);
			Run(2000000000, 2000000000, 2000000000);
			Run(2000000000, 2000000000, 2000000000 - 1);
			Run(2000000000 - 1, 2000000000, 2000000000 - 1);
			Run(2000000000 - 2, 2000000000, 2000000000 - 1);
			Run(6, 11, 2);
		}
		static void Run(int A, int B, int K)
		{
			Console.WriteLine("A={0} B={1} K={2}", A, B, K);
			var s = new Solution();
			var result = s.solution(A, B, K);
			Console.WriteLine("Result: {0}", result);
		}
	}

	class Solution
	{
		public int solution(int A, int B, int K)
		{
			//if (K > B)
			//	return 0;
			var mod = A % K;
			Int64 start = (mod == 0) ? (Int64)A : (Int64)A - (Int64)mod + (Int64)K;
			if (start > B)
				return 0;
			return (B - (int)start) / K + 1;
		}
	}
}
