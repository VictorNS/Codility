using System;

namespace _2_FrogJmp
{
	class Program
	{
		static void Main()
		{
			var res = solution(10, 85, 30);
			Console.WriteLine("Result: {0}", res);
		}
		static int solution(int X, int Y, int D)
		{
			var ret = (Y - X) / D;
			if (X + ret * D == Y)
				return ret;
			return ret + 1;
		}
	}
}
