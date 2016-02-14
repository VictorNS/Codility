using System;

namespace _4_MinAvgTwoSlice
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new int[] { 3, 4, 1, 5 })); // 1
			Console.WriteLine(s.solution(new int[] { 3, 4, 2, 5 })); // 1
			Console.WriteLine(s.solution(new int[] { 3, 4, 3, 5 })); // 0
			Console.WriteLine(s.solution(new int[] { 3, 4, 3, 3, 5 })); // 2
			Console.WriteLine(s.solution(new int[] { 3, 4 })); // 0
			Console.WriteLine(s.solution(new int[] { -3, -5, -8, -4, -10 })); // 2
		}

		class Solution
		{
			public int solution(int[] A)
			{
				if (A.Length < 3)
					return 0;
				decimal minSum2 = (decimal)(A[0] + A[1]) / 2;
				int minSum2Index = 0;
				decimal minSum3 = (decimal)(A[0] + A[1] + A[3]) / 3;
				int minSum3Index = 0;
				for (int i = 0; i < A.Length; i++)
				{
					decimal current;
					if (i - 1 > minSum2Index)
					{
						current = (decimal)(A[i - 1] + A[i]) / 2;
						if (current < minSum2)
						{
							minSum2 = current;
							minSum2Index = i - 1;
						}
					}
					if (i - 2 > minSum3Index)
					{
						current = (decimal)(A[i - 2] + A[i - 1] + A[i]) / 3;
						if (current < minSum3)
						{
							minSum3 = current;
							minSum3Index = i - 2;
						}
					}
				}

				return minSum2 < minSum3 ? minSum2Index : minSum3Index;
			}
		}
	}
}
