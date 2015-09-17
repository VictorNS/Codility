using System;

namespace _1_PermMissingElem
{
	class Program
	{
		static void Main()
		{
			var a = new int[4];
			a[0] = 2;
			a[1] = 3;
			a[2] = 1;
			a[3] = 5;
			var res = solution(a);
			Console.WriteLine("Result: {0}", res);
		}

		static int solution(int[] A)
		{
			var lastEl = A.Length + 1;
			var sum1 = (1 + lastEl) * lastEl / 2;
			Console.WriteLine("ideal sum: {0}, we calclulate N+1, i.e. 5 elements. not 4", sum1);
			var sum2 = 0;
			for (int i = 0; i < A.Length; i++)
			{
				sum2 += A[i];
				Console.WriteLine("index: {0} value: {1} sum: {2}", i, A[i], sum2);
			}
			return sum1-sum2;
		}
	}
}
