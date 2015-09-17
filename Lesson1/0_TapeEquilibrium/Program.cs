using System;

namespace _0_TapeEquilibrium
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] {3,1,2,4,3};
			var res = solution(arr);
			Console.WriteLine(res);
		}

		public static int solution(int[] A)
		{
			var length = A.Length;
			var b = new int[length];
			var prev = 0;
			for (var i = 0; i < length; i++)
			{
				b[i] = prev + A[i];
				prev = b[i];
				Console.WriteLine(prev);
			}
			Console.WriteLine("b is full");
			var min = int.MaxValue;
			var last = b[length - 1];
			for (var i = 1; i < length; i++)
			{
				var prp = Math.Abs(b[i - 1] - (last - b[i - 1]));
				Console.WriteLine(prp);
				if (prp < min)
					min = prp;
			}
			Console.WriteLine("b is scanned");
			return min;
		}
	}
}
