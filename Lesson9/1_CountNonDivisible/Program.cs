using System;

namespace _1_CountNonDivisible
{
	class Program
	{
		static void Main()
		{
			//solution(new int[] { 3, 1, 2, 3, 6 });
			solution(new int[] { 3, 2, 4 });
		}

		public static int[] solution(int[] A)
		{
			int[][] D = new int[A.Length * 2 + 1][];
			for (int i = 0; i < D.Length; i++)
				D[i] = new int[2];

			for (int i = 0; i < A.Length; i++)
			{
				D[A[i]][0]++;
				D[A[i]][1] = -1;
			}

			for (int i = 0; i < A.Length; i++)
			{
				if (D[A[i]][1] == -1)
				{
					D[A[i]][1] = 0;
					for (int j = 1; j <= Math.Sqrt(A[i]); j++)
					{
						if (A[i] % j == 0 && (D[j][0] != 0 || D[A[i] / j][0] != 0))
						{
							if (A[i] / j == j)
							{
								D[A[i]][1] += D[j][0];
							}
							else
							{
								D[A[i]][1] += D[j][0];
								D[A[i]][1] += D[A[i] / j][0];
							}
						}
					}
				}
			}

			for (int i = 0; i < A.Length; i++)
			{
				Console.Write("{0} {1} ", i, A[i]);
				A[i] = A.Length - D[A[i]][1];
				Console.WriteLine(A[i]);
			}
			return A;
		}
	}
}
