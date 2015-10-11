using System;

namespace _3_MaxCounters
{
	class Program
	{
		static void Main()
		{
			var solution = new Solution();
			var A = new int[7];
			A[0] = 3;
			A[1] = 4;
			A[2] = 4;
			A[3] = 6;
			A[4] = 1;
			A[5] = 4;
			A[6] = 4;
			var res = solution.solution(5, A);
			Console.WriteLine("Result:");
			for (int i = 0; i < res.Length; i++)
				Console.WriteLine("{0} = {1}", i, res[i]);
		}
	}

	class Solution
	{
		public int[] solution(int N, int[] A)
		{
			Console.WriteLine();
			var counting = new int[N];
			var max = 0;
			var pier = 0;
			Console.WriteLine("Source:");
			for (int i = 0; i < A.Length; i++)
			{
				Console.WriteLine("{0} = {1}", i, A[i]);
				if (A[i] <= N)
				{
					var cur = counting[A[i] - 1];
					if (cur <= pier)
						counting[A[i] - 1] = pier + 1;
					else
						counting[A[i] - 1] = cur + 1;
					max = Math.Max(max, counting[A[i] - 1]);
				}
				else
				{
					pier = max;
				}
			}
			for (int j = 0; j < N; j++)
				if (counting[j] < pier)
					counting[j] = pier;
			return counting;
		}
	}
}
