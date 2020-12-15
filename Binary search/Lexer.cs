

using System;
using System.Collections;
using System.Text;

namespace lexer
{
	public class Lexer
	{
		public int line = 1;
		private char peek = ' ';
		private Hashtable words = new Hashtable();
		internal virtual void reserve(Word t)
		{
			words[t.lexeme] = t;
		}
		public Lexer()
		{
			reserve(new Word(Tag.TRUE, "true"));
			reserve(new Word(Tag.FALSE, "false"));
		}
		//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
		//ORIGINAL LINE: public Token scan() throws IOException
		public virtual Token scan()
		{
			for (; ; peek = (char)Console.Read())
			{
				if (peek == ' ' || peek == '\t')
				{
					continue;
				}
				else if (peek == '\n')
				{
					line = line + 1;
				}
				else
				{
					break;
				}
			}
			if (char.IsDigit(peek))
			{
				int v = 0;
				do
				{
					v = 10 * v + Char.digit(peek, 10);
					peek = (char)Console.Read();
				} while (char.IsDigit(peek));
				return new Num(v);
			}
			if (char.IsLetter(peek))
			{
				StringBuilder b = new StringBuilder();
				do
				{
					b.Append(peek);
					peek = (char)Console.Read();
				} while (char.IsLetterOrDigit(peek));
				string s = b.ToString();
				Word w = (Word)words[s];
				if (w != null)
				{
					return w;
				}
				w = new Word(s, Tag.ID);
				words[s] = w;
				return w;
			}
			Token t = new Token(peek);
			peek = ' ';
			return t;
		}
	}
}
