using System;

namespace _0_CountSemiprimes
{
	class Program
	{
		static void Main()
		{
			//getArrayF(20);
			//Console.WriteLine("{0} {1}", 2, isSemiprimes(2));
			//Console.WriteLine("{0} {1}", 3, isSemiprimes(3));
			//Console.WriteLine("{0} {1}", 4, isSemiprimes(4));
			//Console.WriteLine("{0} {1}", 5, isSemiprimes(5));
			//Console.WriteLine("{0} {1}", 6, isSemiprimes(6));
			//Console.WriteLine("{0} {1}", 7, isSemiprimes(7));
			//Console.WriteLine("{0} {1}", 8, isSemiprimes(8));
			//Console.WriteLine(findSemiprimes(1, 26));
			//Console.WriteLine(findSemiprimes(4, 10));
			//Console.WriteLine(findSemiprimes(16, 20));
			solution(26, new[] {1, 4, 16}, new[] {26, 10, 20});
		}

		public static int[] solution(int N, int[] P, int[] Q)
		{
			var F = new int[N + 1];
			var i = 2;
			while (i * i <= N)
			{
				if (F[i] == 0)
				{
					var k = i * i;
					while (k <= N)
					{
						if (F[k] == 0)
						{
							F[k] = i;
						}
						k = k + i;
					}
				}
				i++;
			}
			//
			var retina = new int[P.Length];
			for (int j = 0; j < P.Length; j++)
			{
				int nFrom = P[j];
				int nTo = Q[j];
				var res = 0;
				for (int n = nFrom; n <= nTo; n++)
				{
					var dividor = F[n];
					if (dividor != 0)
					{
						dividor = F[n / F[n]];
						if (dividor == 0)
						{
							res++;
							//Console.WriteLine("{0} is {1}", n, res);
						}
					}
				}
				retina[j] = res;
				Console.WriteLine("from {0} to {1} = {2}", nFrom, nTo, res);
			}
			//
			return retina;
		}

		static int findSemiprimes(int nFrom, int nTo)
		{
			Console.WriteLine("from {0} to {1}", nFrom, nTo);
			var F = getArrayF(nTo);
			var res = 0;
			for (int n = nFrom; n <= nTo; n++)
			{
				var dividor = F[n];
				if (dividor != 0)
				{
					dividor = F[n / F[n]];
					if (dividor == 0)
					{
						res++;
						Console.WriteLine("{0} is {1}", n, res);
					}
				}
			}
			return res;
		}

		static bool isSemiprimes(int n)
		{
			var F = getArrayF(n);
			var dividor = F[n];
			if (dividor == 0)
				return false;
			dividor = F[n / F[n]];
			if (dividor == 0)
				return true;
			return false;
		}

		static int[] getArrayF(int n)
		{
			var F = new int[n + 1];
			var i = 2;
			while (i * i <= n)
			{
				if (F[i] == 0)
				{
					var k = i * i;
					while (k <= n)
					{
						if (F[k] == 0)
						{
							F[k] = i;
						}
						k = k + i;
					}
				}
				i++;
			}
			//for (int j = 0; j < F.Length; j++)
			//{
			//	Console.WriteLine("{0} = {1}", j, F[j]);
			//}
			return F;
		}
	}
}
