using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Strategy
{
	interface IImageStrategy
	{
		string LoadImage(string href);
	}
}
