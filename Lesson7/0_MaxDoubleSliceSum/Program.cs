using System;

namespace _0_MaxDoubleSliceSum
{
	class Program
	{
		static void Main()
		{
			//Console.WriteLine("Result: {0}", solutionForSlice(new int[] { 5, -7, 3, 5, -2, 4, -1 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 5, 5, 5 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 5, 5, 5, 5 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 5, 5, 5, 5, 5 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 5, 5, 5, 5, 5, 5 }));
			Console.WriteLine("Result: {0}", solution(new int[] { -2, -3, -4, 1, -5, -6, -7 }));//expected 1
		}
		public static int solution(int[] A)
		{
			Console.WriteLine();
			foreach (var a in A)
				Console.Write(" {0}", a);
			Console.WriteLine();

			if (A.Length < 4)
				return 0;

			var sum = 0;
			var exclude = A[1];
			var result = 0;
			for (int i = 1; i < A.Length - 1; i++)
			{
				var a = A[i];
				var newValue = sum + a;
				exclude = Math.Min(exclude, a);
				int candidate;
				if (newValue - exclude < 0)
				{
					sum = a;
					exclude = a;
					candidate = 0;
				}
				else
				{
					sum = newValue;
					candidate = newValue - exclude;
				}
				result = Math.Max(result, candidate);
			}

			return result;
		}
		public static int solutionBAK(int[] A)
		{
			Console.WriteLine();
			foreach (var a in A)
				Console.Write(" {0}", a);
			Console.WriteLine();

			if (A.Length < 4)
				return 0;
			var sum = 0;
			var exclude = A[1];
			var result = 0;
			for (int i = 1; i < A.Length - 1; i++)
			{
				var a = A[i];
				var newValue = sum + a;
				exclude = Math.Min(exclude, a);
				int candidate;
				if (newValue - exclude < 0)
				{
					sum = 0;
					exclude = a;
					candidate = 0;
				}
				else
				{
					sum = newValue;
					candidate = newValue - exclude;
				}
				result = Math.Max(result, candidate);
			}

			return result;

		}
		public static int solutionForSlice(int[] A)
		{
			Console.WriteLine();
			foreach (var a in A)
				Console.Write(" {0}", a);
			Console.WriteLine();

			var value = 0;
			var result = 0;
			foreach (var a in A)
			{
				var newValue = value + a;
				if (newValue < 0)
					value = 0;
				else
					value = newValue;
				result = Math.Max(result, value);
			}

			return result;

		}
	}
}
