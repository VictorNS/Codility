using System;

namespace _4_MaxCounters
{
	class Program
	{
		static void Main()
		{
			Run(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
			Run(1, new int[] { 1 });
			Run(100, new int[] { 1 });
			Run(1, new int[] { 2 });
			Run(1, new int[] { 1, 2 });
			Run(1, new int[] { 2, 1 });
			Run(1, new int[] { 1, 2, 1 });
		}
		static void Run(int N, int[] input)
		{
			Console.WriteLine();
			Console.Write("Input: {0}, ", N);
			foreach (var i in input)
			{
				Console.Write(" " + i);
			}
			var s = new Solution();
			var result = s.solution(N, input);
			Console.WriteLine();
			Console.Write("Result:");
			foreach (var i in result)
			{
				Console.Write(" " + i);
			}
			Console.WriteLine();
		}
	}

	class Solution
	{
		public int[] solution(int N, int[] A)
		{
			var counting = new int[N];
			var maxLevel = 0;
			var maxValue = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == N + 1)
				{
					maxLevel = maxValue;
				}
				else
				{
					var newValue = Math.Max(maxLevel, counting[A[i] - 1]) + 1;
					maxValue = Math.Max(maxValue, newValue);
					counting[A[i] - 1] = newValue;
				}
			}
			for (int i = 0; i < counting.Length; i++)
			{
				if (counting[i] < maxLevel)
					counting[i] = maxLevel;
			}
			return counting;
		}
	}
}
