using System;

namespace _1_FrogRiverOne
{
	class Program
	{
		static void Main()
		{
			Run(2, new int[] { 1, 3, 2, 4 });
			Run(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
			Run(3, new int[] { });
			Run(5, new int[] { 1, 3, 2, 4 });
		}
		static void Run(int X, int[] input)
		{
			Console.WriteLine();
			Console.Write("Input: {0}, ", X);
			foreach (var i in input)
			{
				Console.Write(" " + i);
			}
			Console.WriteLine();
			var s = new Solution();
			var result = s.solution(X, input);
			Console.WriteLine("Result: {0}", result);
		}
	}

	class Solution
	{
		public int solution(int X, int[] A)
		{
			var counting = new bool[X];
			var countCounting = 0;
			for (int i = 0; i < A.Length; i++)
			{
				var el = A[i];
				if (el > X)
					continue;
				if (counting[el-1])
					continue;
				counting[el - 1] = true;
				countCounting++;
				if (countCounting == X)
					return i;
			}
			return -1;
		}
	}
}
