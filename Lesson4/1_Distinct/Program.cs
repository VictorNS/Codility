using System;
using System.Linq;

namespace _1_Distinct
{
	class Program
	{
		static void Main()
		{
			solution(new int[] { 2, 1, 1, 2, 3, 1 });
			solution(new int[] { 2, 1, 3 });
			solution(new int[] { 2, 1 });
			solution(new int[] { 2 });
			solution(new int[] { });
			solutionLinq(new int[] { 2, 1, 1, 2, 3, 1 });
		}

		public static int solution(int[] A)
		{
			if (A.Length == 0)
			{
				Console.WriteLine("Result: {0}", 0);
				return 0;
			}
			Array.Sort(A);
			var prevEl = A[0];
			var count = 1;
			Console.WriteLine(" {0} = {1}", 0, A[0]);
			for (int i = 1; i < A.Length; i++)
			{
				Console.WriteLine(" {0} = {1}", i, A[i]);
				if (A[i] != prevEl)
				{
					prevEl = A[i];
					count++;
				}
			}
			Console.WriteLine("Result: {0}", count);
			return count;
		}

		public static int solutionLinq(int[] A)
		{
			var distArr = A.Distinct();
			var count = distArr.Count();
			Console.WriteLine("Result: {0}", count);
			return count;
		}

	}
}
