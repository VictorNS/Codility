using System;

namespace _2_PermMissingElem
{
	class Program
	{
		static void Main()
		{
			Run(new int[] { 1 });
			Run(new int[] { 1, 2, 3 });
			Run(new int[] { 1, 3 });
			Run(new int[] { 2, 3, 1, 5 });
			var ar = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				ar[i] = i+1;
			}
			//Run(ar);
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
			// A.Length + 1 because one element is missing
			var shouldbe = (1 + A.Length + 1) * (A.Length + 1) / 2;
			var real = 0;
			for (int i = 0; i < A.Length; i++)
				real += A[i];
			var raznica = shouldbe - real;
			Console.WriteLine("  shouldbe={0} real={1}", shouldbe, real);
			return raznica;
		}
	}
}
