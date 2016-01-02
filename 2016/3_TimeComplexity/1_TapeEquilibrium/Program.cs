using System;

namespace _1_TapeEquilibrium
{
	class Program
	{
		static void Main()
		{
			Run(new int[] { 3, 1, 2, 4, 3 });
			Run(new int[] { -1000, 1000 });
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
			var subSum = new int[A.Length];
			var prevSum = 0;
			for (int i = 0; i < A.Length; i++)
			{
				subSum[i] = prevSum + A[i];
				prevSum = subSum[i];
				Console.WriteLine("  subSum[{0}]={1}", i, prevSum);
			}
			var res = int.MaxValue;
			for (int i = 0; i < subSum.Length - 1; i++)
			{
				var raznica = Math.Abs(subSum[i] - (prevSum - subSum[i]));
				res = Math.Min(res, raznica);
				Console.WriteLine("  {0}-{1}={2} => {3}", subSum[i], prevSum - subSum[i], raznica, res);
			}

			return res;
		}
	}
}
