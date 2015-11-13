using System;
using System.Collections.Generic;

namespace _1_EquiLeader
{
	class Program
	{
		static void Main()
		{
			//Console.WriteLine("Result: {0}", solution(new int[] { }));
			//Console.WriteLine("Result: {0}", solution(new int[] { 3 }));
			//Console.WriteLine("Result: {0}", solution(new int[] { 3, 4 }));
			//Console.WriteLine("Result: {0}", solution(new int[] { 3, 3 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 4, 3, 4, 4, 4, 2 }));
		}

		public static int solution(int[] A)
		{
			Console.WriteLine();
			for (int i = 0; i < A.Length; i++)
				Console.Write(" {0}", i);
			Console.WriteLine();
			for (int i = 0; i < A.Length; i++)
				Console.Write(" {0}", A[i]);
			Console.WriteLine();

			if (A.Length < 2)
				return 0;
			if (A.Length == 2 && A[0] == A[1])
				return 1;
			if (A.Length == 2 && A[0] != A[1])
				return 0;

			var stack = new Stack<int>();
			int? last = null;
			for (int i = 0; i < A.Length; i++)
			{
				if (!last.HasValue)
				{
					stack.Push(A[i]);
					last = A[i];
				}
				else if (A[i] == last)
					stack.Push(last.Value);
				else
				{
					stack.Pop();
					if (stack.Count > 0)
						last = stack.Peek();
					else
						last = null;
				}
			}

			var leader = -1;
			if (stack.Count == 1)
			{
				leader = stack.Pop();
			}
			else
			{
				var length = stack.Count;
				var prp = new Dictionary<int, int>();
				for (int i = 0; i < length; i++)
				{
					var ger = stack.Pop();
					Console.Write(" {0}", ger);
					int inDic;
					if (prp.TryGetValue(ger, out inDic))
					{
						var count = inDic + 1;
						if (count > length / 2)
						{
							leader = ger;
							break;
						}
						prp[ger] = count;
					}
					else
					{
						prp.Add(ger, 1);
					}
				}
				Console.WriteLine();
				if (leader == -1)
					return 0;
			}

			var dispersion = new int[A.Length];
			var counter = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == leader)
					counter++;
				dispersion[i] = counter;
				Console.Write(" {0}", counter);
			}
			Console.WriteLine();

			counter = 0;
			for (int i = 0; i < dispersion.Length; i++)
			{
				var left = dispersion[i];
				var right = dispersion[dispersion.Length - 1] - dispersion[i];
				var leftArrHalf = Decimal.Divide(i + 1, 2);
				var isLeft = left > leftArrHalf;
				var rightArrHalf = Decimal.Divide(dispersion.Length - i - 1, 2);
				var isRight = right > rightArrHalf;
				Console.WriteLine("i={0}    left={1} right={2}    leftArrHalf={5}   rightArrHalf={6}    isLeft={3} isRight={4}", i, left, right, isLeft, isRight, leftArrHalf, rightArrHalf);
				if (isLeft && isRight)
					counter++;
			}
			Console.WriteLine();

			return counter;
		}

		public static int solution2(int[] A)
		{
			var stack = new Stack<int>();

			// count leader
			for (var i = 0; i < A.Length; i++)
			{
				if (stack.Count == 0)
					stack.Push(A[i]);
				else if (stack.Peek() != A[i])
					stack.Pop();
				else
					stack.Push(A[i]);
			}
			if (stack.Count == 0)
				return 0;
			var leader = stack.Pop();

			var totalLeadersCount = 0;
			for (var i = 0; i < A.Length; i++)
				if (A[i] == leader)
					totalLeadersCount++;

			var leadersCount = 0;
			var ret = 0;
			for (var i = 0; i < A.Length - 1; i++)
			{
				if (A[i] == leader)
					leadersCount++;

				if (leadersCount > (i + 1) / 2 &&
						(totalLeadersCount - leadersCount) > (A.Length - i - 1) / 2)
					ret++;
			}

			return ret;
		}
	}
}
