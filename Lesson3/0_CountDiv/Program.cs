using System;

namespace _0_CountDiv
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Result: {0}", solution(0, 6, 3));
			Console.WriteLine("Result: {0}", solution(1, 6, 3));
			Console.WriteLine("Result: {0}", solution(2, 6, 3));
			Console.WriteLine("Result: {0}", solution(4, 6, 3));
			Console.WriteLine("Result: {0}", solution(3, 6, 3));
			Console.WriteLine("Result: {0}", solution(3, 7, 3));
			Console.WriteLine("Result: {0}", solution(3, 8, 3));
			Console.WriteLine("Result: {0}", solution(3, 9, 3));
			Console.WriteLine("Result: {0}", solution(4, 5, 3));
			Console.WriteLine("Result: {0}", solution(6, 11, 2));
		}

		public static int solution(int A, int B, int K)
		{
			Console.WriteLine();
			Console.WriteLine("A: {0} B: {1} K: {2}", A, B, K);
			int startNumber;
			var mod = A % K;
			if (mod == 0)
			{
				startNumber = A;
			}
			else
			{
				startNumber = A - mod + K;
				if (startNumber > B)
					return 0;
			}
			Console.WriteLine("  startNumber: {0}", startNumber);
			var difference = B - startNumber;
			return difference / K + 1;
		}
	}
}
