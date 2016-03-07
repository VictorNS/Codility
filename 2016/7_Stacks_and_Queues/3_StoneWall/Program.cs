using System;

namespace _3_StoneWall
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }));

			Console.WriteLine(s.solution(new[] { 8, 8, 0, 5, 7, 9, 8, 7, 4, 8 }));
			Console.WriteLine(s.solution(new[] { 8, 8, 0, 5, 7, 9, 8, 7, 0, 4, 8 }));
			Console.WriteLine(s.solution(new[] { 8 }));

			var ar = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				ar[i] = 1000000000 - i;
			}
			Console.WriteLine(s.solution(ar));
		}
		class Solution
		{
			public int solution(int[] H)
			{
				var blockCount = 0;
				var stack = new System.Collections.Generic.Stack<Tuple<int, int>>();

				foreach (var h in H)
				{
					var lastBlockBottom = 0;
					var lastBlockTop = 0;
					if (stack.Count != 0)
					{
						var lastBlock = stack.Peek();
						lastBlockBottom = lastBlock.Item1;
						lastBlockTop = lastBlock.Item2;
					}
					if (h > lastBlockTop)
					{
						stack.Push(new Tuple<int, int>(lastBlockTop, h));
					}
					else if (h < lastBlockTop)
					{
						stack.Pop();
						blockCount++;

						while (h < lastBlockBottom)
						{
							var lastBlock = stack.Pop();
							blockCount++;
							lastBlockBottom = lastBlock.Item1;
						}
						if (h > lastBlockBottom)
						{
							stack.Push(new Tuple<int, int>(lastBlockBottom, h));
						}
					}
				}

				return blockCount + stack.Count;
			}
		}
	}
}
