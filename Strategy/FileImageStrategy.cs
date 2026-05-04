using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Strategy
{
	class FileImageStrategy : IImageStrategy
	{
		public string LoadImage(string href)
		{
			return $"[Image loaded from file: {href}]";
		}
	}
}
