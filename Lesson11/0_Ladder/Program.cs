using System;
using System.Collections.Generic;
using System.Linq;

namespace _0_Ladder
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			//var result = s.solution(new int[] { 4, 4, 5, 5, 1 }, new int[] { 3, 2, 4, 3, 1 });
			var result = s.solution(new int[] { 30000 }, new int[] { 30 });
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(result[i]);
			}
		}

		private class Solution
		{

			public int[] solution(int[] A, int[] B)
			{
				var maxApreparedFib = 1;
				var fib = new List<int>() { 0, 1 };
				int bMax = B.Max();
				int modLimit = (1 << bMax) - 1;

				var result = new int[A.Length];
				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] + 1 > maxApreparedFib)
					{
						calcFib(fib, modLimit, A[i] + 1, ref maxApreparedFib);
					}
					var aa = fib[A[i] + 1];
					var bb = (1 << B[i]);
					result[i] = aa & (bb - 1); // aa % bb
				}
				return result;
			}

			void calcFib(List<int> fib, int modLimit, int topLimit, ref int maxApreparedFib)
			{
				for (int i = maxApreparedFib + 1; i <= topLimit; i++)
				{
					fib.Add((fib[i - 1] + fib[i - 2]) & modLimit);
				}
				maxApreparedFib = topLimit;
			}
		}

	}
}
