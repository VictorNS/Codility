using System;
using System.Linq;

namespace _1_OddOccurrencesInArray
{
	class Program
	{
		static void Main()
		{
			Run(new int[] { 9, 3, 9, 3, 9, 7, 9 });
		}
		static void Run(int[] input)
		{
			Console.WriteLine();
			Console.WriteLine("Input: ");
			foreach (var i in input)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			var s = new Solution();
			var result = s.solution(input);
			Console.WriteLine("Result: {0}", result);
		}
	}

	class Solution
	{
		public int solution0(int[] A)
		{
			var l = new System.Collections.Generic.List<int>();
			for (int i = 0; i < A.Length; i++)
			{
				if (l.Contains(A[i]))
				{
					l.Remove(A[i]);
				}
				else
				{
					l.Add(A[i]);
				}
			}
			return l.FirstOrDefault();
		}
		public int solution(int[] A)
		{
			var res = 0;
			for (int i = 0; i < A.Length; i++)
			{
				res = res ^ A[i];
			}
			return res;
		}
	}
}
