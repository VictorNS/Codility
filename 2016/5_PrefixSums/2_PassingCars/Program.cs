using System;

namespace _2_PassingCars
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution(new int[] { 0, 1, 0, 1, 1 }));

			var a1 = new int[10000100];
			for (int i = 100; i < a1.Length; i++)
				a1[i] = 1;
			Console.WriteLine("{0} in array with length: {1}", s.solution(a1), a1.Length);

			var a2 = new int[10000101];
			for (int i = 100; i < a2.Length; i++)
				a2[i] = 1;
			Console.WriteLine("{0} in array with length: {1}", s.solution(a2), a2.Length);

			var a3 = new int[10000000];
			Console.WriteLine("{0} in array with length: {1}", s.solution(a3), a3.Length);

			var a4 = new int[10000000];
			for (int i = 0; i < a4.Length; i++)
				a4[i] = 1;
			Console.WriteLine("{0} in array with length: {1}", s.solution(a4), a4.Length);
		}

		class Solution
		{
			public int solution(int[] A)
			{
				var count = 0;
				var factor = 0;
				for (int i = 0; i < A.Length; i++)
				{
					if (A[i] == 0)
						factor++;
					else
						count += factor;
					if (count > 1000000000)
						return -1;
				}
				return count;
			}
		}
	}
}
