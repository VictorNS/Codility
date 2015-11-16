using System;

namespace _1_MaxProfit
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Result: {0}", solution(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 3, 1, 2, 1, 100 }));
		}
		public static int solution(int[] A)
		{
			Console.WriteLine();
			foreach (var a in A)
				Console.Write(" {0}", a);
			Console.WriteLine();

			if (A.Length < 1)
				return 0;

			var max = A[0];
			var min = A[0];
			var raznica=0;
			for (var i = 1; i < A.Length; i++)
			{
				var a = A[i];
				if (a < min)
				{ 
					min = a;
					max = a;
				}
				else
				{
					max = Math.Max(max, a);
				}
				raznica = Math.Max(raznica, max - min);
				Console.WriteLine("i {4} a {0} min {1} max {2} raznica {3}", a, min, max, raznica, i);
			}

			return raznica;
		}
	}
}
