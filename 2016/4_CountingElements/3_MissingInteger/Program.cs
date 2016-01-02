using System;

namespace _3_MissingInteger
{
	class Program
	{
		static void Main()
		{
			Run(new int[] { 0 });
			Run(new int[] { 1 });
			Run(new int[] { 1, 2 });
			Run(new int[] { 4, 1, 2, 3 });
			Run(new int[] { 4, 1, 3 });
			Run(new int[] { 1, 3, 6, 4, 1, 2 });
			Run(new int[] { 100001, 100002, 100003 });
			Run(new int[] { -1, -2 });
		}
		static void Run(int[] input)
		{
			Console.WriteLine();
			Console.Write("Input:");
			foreach (var i in input)
			{
				Console.Write(" " + i);
			}
			Console.WriteLine();
			var s = new Solution();
			var result = s.solution(input);
			Console.WriteLine("Result: {0}", result);
		}
	}

	class Solution
	{
		public int solution(int[] A)
		{
			var max = 100001;
			var counting = new bool[max];
			for (int i = 0; i < Math.Min(max, A.Length); i++)
			{
				if (0 >= A[i] || A[i] > max)
					continue;
				counting[A[i] - 1] = true;
			}
			for (int i = 0; i < max; i++)
			{
				if (!counting[i])
					return i+1;
			}
			return 0;
		}
	}
}
