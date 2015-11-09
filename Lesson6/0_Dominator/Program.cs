using System;
using System.Collections.Generic;

namespace _0_Dominator
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Result: {0}", solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));
			Console.WriteLine("Result: {0}", solution(new int[] { }));
			Console.WriteLine("Result: {0}", solution(new int[] { 3 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 3, 4 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 3, 3 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 3, 3, 2, 1 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 1, 2, 3, 3 }));
			Console.WriteLine("Result: {0}", solution(new int[] { 1, 2, 3, 3, 3 }));
		}

		public static int solution(int[] A)
		{
			Console.WriteLine();
			for (int i = 0; i < A.Length; i++)
				Console.Write(" {0}", A[i]);
			Console.WriteLine();

			if (A.Length == 0)
				return -1;
			if (A.Length == 1)
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
					return -1;
			}

			var counter = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == leader)
				{
					counter++;
					if (counter > A.Length / 2)
						return i;
				}
			}

			return -1;
		}
	}
}
