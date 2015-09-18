using System;

namespace _0_FrogRiverOne
{
	class Program
	{
		static void Main(string[] args)
		{
			var solution = new Solution();
			var A = new int[8];
			A[0] = 1;
			A[1] = 3;
			A[2] = 1;
			A[3] = 4;
			A[4] = 2;
			A[5] = 3;
			A[6] = 5;
			A[7] = 4;
			var res = solution.solution(5, A);
			Console.WriteLine("Result: {0}", res);
		}
	}

	class Solution
	{
		public int solution(int X, int[] A)
		{
			var counting = new int[X + 1];
			var counter = 0;
			for (int i = 0; i < A.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, A[i]);
				if (A[i] <= X && counting[A[i]] == 0)
				{
					Console.WriteLine("	accepted");
					counting[A[i]] += 1;
					counter++;
					if (counter == X)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public int[] createCounting(int[] A, int m)
		{
			var n = A.Length;
			var count = new int[m+1];
			for (int k = 0; k < n; k++)
			{
				if (A[k] <= m)
				{
					count[A[k]] += 1;
				}
			}
			Console.WriteLine("counting:");
			for (int i = 0; i < count.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, count[i]);
			}
			return count;
		}
	}
}
