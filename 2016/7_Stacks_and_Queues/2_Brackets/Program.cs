using System;

namespace _2_Brackets
{
	class Program
	{
		static void Main()
		{
			var s = new Solution();
			Console.WriteLine(s.solution("{"));
			Console.WriteLine(s.solution("{[()()]}"));
			Console.WriteLine(s.solution("([)()]"));
			var sb = new System.Text.StringBuilder(200000);
			for (int i = 0; i < 100000; i++)
				sb.Append('(');
			for (int i = 0; i < 100000; i++)
				sb.Append(')');
			Console.WriteLine(s.solution(sb.ToString()));
		}
		class Solution
		{
			public int solution(string S)
			{
				var stack = new System.Collections.Generic.Stack<char>();
				foreach (var s in S)
				{
					if (-1 == "{[(".IndexOf(s))
					{
						if (stack.Count == 0)
							return 0;
						var z = stack.Pop();
						switch (s)
						{
							case '}':
								if (z != '{')
									return 0;
								break;
							case ']':
								if (z != '[')
									return 0;
								break;
							case ')':
								if (z != '(')
									return 0;
								break;
						}
					}
					else
					{
						stack.Push(s);
					}
				}
				return (stack.Count == 0) ? 1 : 0;
			}
		}
	}
}
