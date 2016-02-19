using System;

namespace _1_Distinct
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new[] { 2, 1, 1, 2, 3, 1 }));
			Console.WriteLine(s.solution(new int[0]));
			Console.WriteLine(s.solution(new int[100000]));
			var ints = new int[100000];
			ints[0] = 1;
			ints[99999] = 2;
			Console.WriteLine(s.solution(ints));
		}
		class Solution
		{
			public int solution(int[] A)
			{
				Array.Sort(A);
				int previous = -2000000;
				int distinct = 0;

				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] != previous)
					{
						previous = A[i];
						distinct++;
					}
				}

				return distinct;
			}
		}
	}
}
