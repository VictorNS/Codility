using System;

namespace _3_MaxProductOfThree
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new[] { -3, 1, 2, -2, 5, 6 }));
			Console.WriteLine(s.solution(new[] { -2, -1, 3, 4 }));
			Console.WriteLine(s.solution(new[] { -2, 1, 3, 4 }));
			Console.WriteLine(s.solution(new int[3]));
			Console.WriteLine(s.solution(new int[100000]));
			int[] ints;
			ints = new int[100000];
			ints[0] = 1;
			ints[500] = 2;
			ints[99999] = 3;
			Console.WriteLine(s.solution(ints));
		}
		class Solution
		{
			public int solution(int[] A)
			{
				Array.Sort(A);

				var l = A.Length;
				var maxPos = A[l - 3] * A[l - 2] * A[l - 1];
				var maxNeg = A[0] * A[1] * A[2];
				var maxMix = A[0] * A[1] * A[l - 1];

				return Math.Max(Math.Max(maxPos, maxNeg), maxMix);
			}
		}
	}
}
