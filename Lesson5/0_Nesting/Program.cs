using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Nesting
{
	class Program
	{
		static void Main(string[] args)
		{
			solution("");
			solution("(");
			solution(")");
			solution("()");
			solution(")(");
			solution("(()(())())");
			solution(new StringBuilder().Insert(0, "(()(())())", 100000).ToString());
		}

		public static int solution(string S)
		{
			if (S.Length>100)
				Console.WriteLine("Input: " + S.Length);
			else
				Console.WriteLine("Input: " + S);
			if (string.IsNullOrEmpty(S))
			{
				Console.WriteLine("Result: 1");
				return 1;
			}
			Stack<bool> stack=new Stack<bool>();
			foreach (char c in S)
			{
				if (c=='(')
					stack.Push(true);
				else
				{
					if (stack.Count == 0)
					{
						Console.WriteLine("Result: 0");
						return 0;
					}
					stack.Pop();
				}
			}
			var res = stack.Count == 0 ? 1 : 0;
			Console.WriteLine("Result: " + res);
			return res;
		}
	}
}
