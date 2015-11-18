using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CountingDivisors
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(solution(10));
		}

		static int solution(int n)
		{
			Console.WriteLine();
			for (int j = 1; j <= n; j++)
				Console.Write("{0} ", j);
			Console.WriteLine();

			var i = 1;
			var result = 0;
			while (i * i < n)
			{
				if (n % i == 0)
					result += 2;
				Console.WriteLine("n {0}  i {1}  n % i {2} result  {3}", n, i, n % i, result);
				i += 1;
			}
			if (i * i == n)
				result += 1;
			Console.WriteLine("n {0}  i {1}  i*i {2} result  {3}", n, i, i * i, result);
			return result;
		}
	}
}
