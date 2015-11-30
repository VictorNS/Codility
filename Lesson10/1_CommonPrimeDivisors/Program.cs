using System;

namespace _1_CommonPrimeDivisors
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(solution(
				new int[] {15,10,3}, 
				new int[] {75,30,5}));
		}

		public static int solution(int[] A, int[] B)
		{
			var res = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (analyze(A[i], B[i]))
					res++;
			}
			return res;
		}

		public static bool analyze(int a, int b)
		{
			var maxDivider = gcd(a, b); // maybe maxDivider contains all common prime dividers
			var checkA = checkAnotherDivider(a, maxDivider);
			var checkB = checkAnotherDivider(b, maxDivider);
			return checkA && checkB;
		}

		public static bool checkAnotherDivider(int x, int maxDivider)
		{
			while (x != 1)
			{
				var localDivider = gcd(x, maxDivider); // we'd like to find divider
				Console.WriteLine("  x={0}  maxDidvider={1}  localMax={2} => x/localMax={3}", x, maxDivider, localDivider, x / localDivider);
				if (localDivider == 1)
				{
					break;
				}
				x = x / localDivider; // if maxDivider realy contains ALL common prime dividers
				// we can divide and divide until receive 1
			}
			return x == 1;
		}

		public static int gcd(int a, int b)
		{
			if (a % b == 0)
				return b;
			return gcd(b, a % b);
		}

	}
}
