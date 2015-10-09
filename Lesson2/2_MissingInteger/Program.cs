using System;

namespace _2_MissingInteger
{
	class Program
	{
		static void Main()
		{
			var solution = new Solution();
			var A = new int[6];
			A[0] = 1;
			A[1] = 3;
			A[2] = 6;
			A[3] = 4;
			A[4] = 1;
			A[5] = 2;
			Console.WriteLine("Result: {0}", solution.solution(A));
			A[0] = -1;
			A[1] = 3;
			A[2] = -6;
			A[3] = 4;
			A[4] = -1;
			A[5] = 2;
			Console.WriteLine("Result: {0}", solution.solution(A));
			A[0] = 2147483647;
			A[1] = 2147483640;
			A[2] = 2147483641;
			A[3] = 2147483642;
			A[4] = 2;
			A[5] = 1;
			Console.WriteLine("Result: {0}", solution.solution(A));
			A = new int[1];
			A[0] = 1;
			Console.WriteLine("Result: {0}", solution.solution(A));
		}
	}

	class Solution
	{
		public int solution(int[] A)
		{
			Console.WriteLine();
			var max = A.Length;
			var counting = new int[max];
			Console.WriteLine("Source:");
			for (int i = 0; i < A.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, A[i]);
				if (A[i] > 0 && A[i] <= max)
					counting[A[i]-1] = 1;
			}
			Console.WriteLine("counting:");
			for (int i = 0; i < counting.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, counting[i]);
				if (counting[i] == 0)
					return i + 1;
			}
			return max + 1;
		}
	}
}
