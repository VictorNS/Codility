using System;

namespace _0_MaxProductOfThree
{
	class Program
	{
		static void Main()
		{
			var A = new int[4];
			A[0] = -3;
			A[1] = -1;
			A[2] = -2;
			A[3] = -4;
			Console.WriteLine("Result: {0}", solution(A));

			A[0] = 3;
			A[1] = 1;
			A[2] = 2;
			A[3] = 4;
			Console.WriteLine("Result: {0}", solution(A));

			A[0] = -3;
			A[1] = -1;
			A[2] = -2;
			A[3] = 0;
			Console.WriteLine("Result: {0}", solution(A));

			A[0] = -5;
			A[1] = 5;
			A[2] = -5;
			A[3] = 4;
			Console.WriteLine("Result: {0}", solution(A));
		}

		public static int solution(int[] A)
		{
			Array.Sort(A);
			for (int i = 0; i < A.Length; i++)
				Console.WriteLine("{0} = {1}", i, A[i]);
			return Math.Max(
					A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3],
					A[0] * A[1] * A[A.Length - 1]
			);
		}
	}
}
