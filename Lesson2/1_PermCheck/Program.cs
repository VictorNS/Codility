using System;

namespace _1_PermCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			var solution = new Solution();
			var A = new int[3];
			A[0] = 1;
			A[1] = 3;
			A[2] = 4;
			Console.WriteLine("Result: {0}", solution.solution(A));
			Array.Resize(ref A, 4);
			A[3] = 4;
			Console.WriteLine("Result: {0}", solution.solution(A));
			A[3] = 5;
			Console.WriteLine("Result: {0}", solution.solution(A));
			A[3] = 2;
			Console.WriteLine("Result: {0}", solution.solution(A));
		}
	}

	class Solution
	{
		public int solution(int[] A)
		{
			Console.WriteLine();
			var max = A.Length;
			var counting = new int[max + 1];
			var counter = 0;
			Console.WriteLine("Source:");
			for (int i = 0; i < A.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, A[i]);
				if (A[i] > max)
					return 0;
				if (counting[A[i]] == 1)
					return 0;
				counting[A[i]] = 1;
			}
			Console.WriteLine("counting:");
			for (int i = 0; i < counting.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, counting[i]);
				counter += counting[i];
			}
			if (counter == max)
				return 1;
			return 0;
		}
	}
}
