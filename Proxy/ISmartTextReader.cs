using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Proxy
{
	interface ISmartTextReader
	{
		char[][] Read(string path);
	}
}
