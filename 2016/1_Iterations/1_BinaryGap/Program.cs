using System;

namespace _1_BinaryGap
{
	class Program
	{
		static void Main()
		{
			Run(1041);
			Run(6);
		}
		static void Run(int input)
		{
			Console.WriteLine();
			Console.WriteLine("Input: {0}", input);
			var s = new Solution();
			var result = s.solution(input);
			Console.WriteLine("Result: {0}", result);
		}
	}

	class Solution
	{
		public int solution(int N)
		{
			var b = Convert.ToString(N, 2);
			var maxLength = 0;
			var currentLength = 0;
			for (int i = 0; i < b.Length; i++)
			{
				Console.Write(b[i]);
				if (b[i] == '1')
				{
					maxLength = Math.Max(maxLength, currentLength);
					currentLength = 0;
				}
				else
				{
					currentLength++;
				}
			}
			Console.WriteLine();
			return maxLength;
		}
	}
}
