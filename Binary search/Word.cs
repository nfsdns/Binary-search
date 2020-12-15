using Compiler;
namespace lexer 
{
	public class Word : Token
	{
		public readonly string lexeme;
		public Word(int t, string s) : base(t)
		{
			lexeme = s;
		}
	}
}

