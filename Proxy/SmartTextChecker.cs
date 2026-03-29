using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Proxy
{
	class SmartTextChecker : ISmartTextReader
	{
		private ISmartTextReader reader;

		public SmartTextChecker(ISmartTextReader reader)
		{
			this.reader = reader;
		}

		public char[][] Read(string path)
		{
			Console.WriteLine("Opening file...");

			var result = reader.Read(path);

			Console.WriteLine("Reading file...");

			int lines = result.Length;
			int chars = result.Sum(line => line.Length);

			Console.WriteLine($"Lines: {lines}, Characters: {chars}");
			Console.WriteLine("Closing file...");

			return result;
		}
	}
}
