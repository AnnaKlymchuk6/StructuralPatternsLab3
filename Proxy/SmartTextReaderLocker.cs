using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Proxy
{
	using System.Text.RegularExpressions;

	class SmartTextReaderLocker : ISmartTextReader
	{
		private ISmartTextReader reader;
		private Regex regex;

		public SmartTextReaderLocker(ISmartTextReader reader, string pattern)
		{
			this.reader = reader;
			this.regex = new Regex(pattern);
		}

		public char[][] Read(string path)
		{
			if (regex.IsMatch(path))
			{
				Console.WriteLine("Access denied!");
				return new char[0][];
			}

			return reader.Read(path);
		}
	}
}
