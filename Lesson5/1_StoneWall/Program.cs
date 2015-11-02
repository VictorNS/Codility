using System;
using System.Collections.Generic;

namespace _1_StoneWall
{
	class Program
	{
		static void Main(string[] args)
		{
			solution(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });
			//solution(new int[] { 3, 5, 3 });
			//solution(new int[] { 3, 5, 5, 3 });
			//solution(new int[] { 4, 3, 5, 3 });
			//solution(new int[] { 4, 3, 5, 2 });
			//solution(new int[] { 4, 3, 5, 4 });
			//solution(new int[] { 1, 3, 2 });
			//solution(new int[] { 1, 3, 2, 1 });
		}

		public static int solution(int[] H)
		{
			Console.WriteLine();
			for (int i = 0; i < H.Length; i++)
				Console.Write(" {0}", H[i]);
			Console.WriteLine();

			var stack = new Stack<Block>();
			var wall = new Stack<Block>();
			var lastHeight = 0;
			for (int i = 0; i < H.Length; i++)
			{
				if (H[i] > lastHeight)
				{
					stack.Push(new Block() { WallHeight = H[i] });
					lastHeight = H[i];
				}
				else if (H[i] < lastHeight)
				{
					var b = stack.Peek();
					while (b.WallHeight > H[i])
					{
						b = stack.Pop();
						wall.Push(b);
						if (stack.Count == 0)
							break;
						b = stack.Peek();
					}
					if (stack.Count == 0 || b.WallHeight < H[i])
						stack.Push(new Block() { WallHeight = H[i] });
					lastHeight = H[i];
				}
			}

			Console.WriteLine("Result: {0}", wall.Count + stack.Count);
			return wall.Count + stack.Count;
		}

		public class Block
		{
			public int WallHeight { get; set; }
		}
	}
}
