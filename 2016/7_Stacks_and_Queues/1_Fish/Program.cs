using System;

namespace _1_Fish
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(
				new[] { 5, 1, 3, 1, 1 },
				new[] { 1, 1, 0, 0, 0 }));
			Console.WriteLine(s.solution(
				new[] { 1, 2, 1, 1, 1 },
				new[] { 0, 1, 0, 0, 0 }));
			Console.WriteLine(s.solution(
				new[] { 1, 2, 4, 3, 5 },
				new[] { 0, 1, 0, 1, 0 }));
			Console.WriteLine(s.solution(
				new[] { 1, 2, 1, 3, 1 },
				new[] { 0, 1, 0, 1, 0 }));
			Console.WriteLine(s.solution(
				new[] { 1, 4, 2, 3, 5 },
				new[] { 0, 1, 0, 1, 0 }));
			Console.WriteLine(s.solution(
				new[] { 1, 1, 3, 1, 1 },
				new[] { 0, 1, 0, 0, 0 }));

			Console.WriteLine(s.solution(new[] { 1 }, new[] { 0 }));
			Console.WriteLine(s.solution(new[] { 1 }, new[] { 1 }));

			var A = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				A[i] = 1000000000 - i;
			}
			var B = new int[100000];
			B[0] = 1;
			Console.WriteLine(s.solution(A, B));
		}
		class Solution
		{
			public int solution(int[] A, int[] B)
			{
				var ret = 0;
				var up = new System.Collections.Generic.Stack<int>();
				for (int i = A.Length - 1; i >= 0; i--)
				{
					if (B[i] == 1)
					{
						while (up.Count > 0)
						{
							var fishSize = up.Peek();
							if (A[i] > fishSize)
								up.Pop(); // remove one from stack
							else
								break; // downFish was eaten, break circle
						}
						if (up.Count == 0)
							ret++; // downFish ate all upFishes
					}
					else
					{
						up.Push(A[i]);
					}
				}
				while (up.Count > 0)
				{
					var fishSize = up.Pop();
					ret++;
				}
				return ret;
			}
		}
	}
}
