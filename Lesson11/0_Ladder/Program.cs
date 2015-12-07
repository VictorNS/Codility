using System;
using System.Collections.Generic;

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
				var maxFib = 1;
				var fib = new List<int>() { 0, 1 };

				var result = new int[A.Length];
				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] + 1 > maxFib)
					{
						calcFib(fib, A[i] + 1, ref maxFib);
					}
					var aa = fib[A[i] + 1];
					var bb = (1 << B[i]);
					result[i] = aa % bb;
				}
				return result;
			}

			void calcFib(List<int> fib, int limit, ref int maxFib)
			{
				for (int i = maxFib + 1; i <= limit; i++)
				{
					fib.Add(fib[i - 1] + fib[i - 2]);
				}
				maxFib = limit;
			}
		}

	}
}
