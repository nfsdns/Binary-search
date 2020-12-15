﻿
using Compiler;

namespace lexer // File Num.java
{
	public class Num : Token
	{
		public readonly int value;
		public Num(int v) : base(Tag.NUM)
		{
			value = v;
		}
	}
}
