using System;

namespace _2_PermCheck
{
	class Program
	{
		static void Main()
		{
			Run(new int[] { 1 });
			Run(new int[] { 1, 2 });
			Run(new int[] { 4, 1, 2, 3 });
			Run(new int[] { 4, 1, 3 });
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
			var max = A.Length;
			var counting = new bool[max];
			for (int i = 0; i < max; i++)
			{
				if (A[i] > max)
					return 0;
				if (counting[A[i] - 1])
					return 0;
				counting[A[i] - 1] = true;
			}
			return 1;
		}
	}
}
