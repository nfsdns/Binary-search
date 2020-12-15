using System;
using Compiler;
namespace Parser
{
	internal class Parser
	{
		internal static int lookahead;

		public Parser()
		{
			lookahead = Console.Read();
		}
		internal virtual void Expr()
		{
			Term();
			while (true)
			{
				if (lookahead == '+')
				{
					Match('+');
					Term();
					Console.WriteLine('+');
				}
				else if (lookahead == '-')
				{
					Match('-');
					Term();
					Console.WriteLine('-');
				}
				else
				{
					return;
				}
			}
		}

		internal virtual void Term()
		{
			if (char.IsDigit((char)lookahead))
			{
				Console.WriteLine((char)lookahead);
				Match(lookahead);
			}
			else
			{
				throw new Exception("syntax error");
			}
		}

		internal virtual void Match(int t)
		{
			if (lookahead == t)
			{
				lookahead = Console.Read();
			}
			else
			{
				throw new Exception("syntax error");
			}
		}
	}
	public class Postfix
	{

		public static void Main(string[] args)
		{
			Parser parse = new Parser();
			parse.Expr();
			Console.WriteLine('\n');
		}
	}
}


