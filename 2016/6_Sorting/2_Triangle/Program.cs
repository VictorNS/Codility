using System;

namespace _2_Triangle
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new[] { 10, 2, 5, 1, 8, 20 }));
			Console.WriteLine(s.solution(new[] { 10, 50, 5, 1 }));
			Console.WriteLine(s.solution(new int[0]));
			Console.WriteLine(s.solution(new int[100000]));
			int[] ints;
			ints = new int[100000];
			ints[0] = 1;
			ints[99999] = 2;
			Console.WriteLine(s.solution(ints));
			ints = new int[100000];
			ints[0] = 2;
			ints[1] = 3;
			ints[2] = 4;
			Console.WriteLine(s.solution(ints));
		}
		class Solution
		{
			public int solution(int[] A)
			{
				Array.Sort(A);

				for (int i = 0; i < A.Length-2; i++)
				{
					if (A[i] + A[i + 1] > A[i + 2])
						return 1;
				}

				return 0;
			}
		}
	}
}
