using System;

namespace _2_MaxSliceSum
{
	class Program
	{
		static void Main()
		{
			//Console.WriteLine("Result: {0}", solution(new int[] { 3, 2, -6, 4, 0 }));
			Console.WriteLine("Result: {0}", solution(new int[] { -2, -3, -1, 1 }));
		}
		public static int solution(int[] A)
		{
			Console.WriteLine();
			foreach (var a in A)
				Console.Write(" {0}", a);
			Console.WriteLine();

			if (A.Length < 2)
				return A[0];

			var value = A[0];
			var result = A[0];
			for (var i = 1; i < A.Length; i++)
			{
				var a = A[i];
				var newValue = value + a;
				if (result >= 0)
				{
					value = Math.Max(newValue, 0);
				}
				else
				{
					value = Math.Max(newValue, a);
				}

				result = Math.Max(result, value);
				Console.WriteLine("a {0}  newValue {1} value {2} result {3}", a, newValue, value, result);
			}

			return result;
		}
	}
}
