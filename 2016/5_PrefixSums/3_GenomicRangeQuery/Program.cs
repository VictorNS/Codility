using System;

namespace _3_GenomicRangeQuery
{
	class Program
	{
		static void Main()
		{
			Exec("A", new[] { 0 }, new[] { 0 });

			Exec("ACGT", new[] { 0 }, new[] { 0 });
			Exec("ACGT", new[] { 1 }, new[] { 1 });
			Exec("ACGT", new[] { 2 }, new[] { 2 });
			Exec("ACGT", new[] { 3 }, new[] { 3 });

			Exec("ACGT", new[] { 0 }, new[] { 1 });
			Exec("ACGT", new[] { 0 }, new[] { 2 });
			Exec("ACGT", new[] { 0 }, new[] { 3 });

			Exec("ACGT", new[] { 1 }, new[] { 1 });
			Exec("ACGT", new[] { 1 }, new[] { 2 });
			Exec("ACGT", new[] { 1 }, new[] { 3 });

			Exec("ACGT", new[] { 2 }, new[] { 2 });
			Exec("ACGT", new[] { 2 }, new[] { 3 });

			Exec("CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 });
		}

		private static void Exec(string p1, int[] p2, int[] p3)
		{
			var s = new Solution();
			var re = s.solution(p1, p2, p3);
			Console.WriteLine();
			Console.WriteLine("EXEC " + p1);
			for (int i = 0; i < Math.Min(p2.Length, 10); i++)
				Console.Write(" " + p2[i]);
			Console.WriteLine();
			for (int i = 0; i < Math.Min(p3.Length, 10); i++)
				Console.Write(" " + p3[i]);
			Console.WriteLine();
			Console.Write("Result");
			for (int i = 0; i < Math.Min(re.Length, 10); i++)
				Console.Write(" " + re[i]);
			Console.WriteLine();
		}

		class Solution
		{
			public int[] solution(string S, int[] P, int[] Q)
			{
				var sumA = new int[S.Length + 1];
				var sumC = new int[S.Length + 1];
				var sumG = new int[S.Length + 1];
				int iA = 0, iC = 0, iG = 0;

				for (int i = 0; i < S.Length; i++)
				{
					switch (S[i])
					{
						case 'A':
							iA++;
							break;
						case 'C':
							iC++;
							break;
						case 'G':
							iG++;
							break;
					}
					sumA[i + 1] = iA;
					sumC[i + 1] = iC;
					sumG[i + 1] = iG;
				}

				var ret = new int[P.Length];
				for (int i = 0; i < P.Length; i++)
				{
					if (sumA[Q[i] + 1] - sumA[P[i]] > 0)
						ret[i] = 1;
					else if (sumC[Q[i] + 1] - sumC[P[i]] > 0)
						ret[i] = 2;
					else if (sumG[Q[i] + 1] - sumG[P[i]] > 0)
						ret[i] = 3;
					else
						ret[i] = 4;
				}
				return ret;
			}
		}
	}
}
