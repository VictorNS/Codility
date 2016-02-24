using System;

namespace _4_NumberOfDiscIntersections
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new[] { 1, 5, 2, 1, 4, 0 }));
			Console.WriteLine(s.solution(new[] { 1, 0, 0, 1 }));
			Console.WriteLine(s.solution(new int[0]));
			Console.WriteLine(s.solution(new int[100000]));
			var ints = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				ints[i] = int.MaxValue;
			}
			Console.WriteLine(s.solution(ints));
		}
		class Solution
		{
			public int solution(int[] A)
			{
				var a = new Tuple<long, long>[A.Length];
				for (int i = 0; i < A.Length; i++)
				{
					a[i] = new Tuple<long, long>(((long)i - (long)A[i]), ((long)i + (long)A[i]));
				}
				Array.Sort(a);
				var result = 0;
				for (int i = 0; i < a.Length; i++)
				{
					var j = 1;
					while ((i + j < a.Length) && (a[i].Item2 >= a[i + j].Item1))
					{
						result++;
						j++;
						if (result > 10000000)
							return -1;
					}
				}
				return result;
			}
		}
	}
}
