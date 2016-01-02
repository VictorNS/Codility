using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FrogJmp
{
	class Program
	{
		static void Main()
		{
			Run(1, 1, 2);
			Run(0, 1, 2);
			Run(0, 2, 2);
			Run(0, 3, 2);
		}
		static void Run(int X, int Y, int D)
		{
			Console.WriteLine("Input: {0} {1} {2}", X, Y, D);
			var s = new Solution();
			var result = s.solution(X, Y, D);
			Console.WriteLine("Result: {0}", result);
		}
	}

	class Solution
	{
		public int solution(int X, int Y, int D)
		{
			var distance = Y - X;
			var res = distance / D;
			return D * res < distance ? res + 1 : res;
		}
	}
}
