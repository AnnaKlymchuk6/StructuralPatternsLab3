using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	abstract class LightNode
	{
		public abstract string OuterHTML();
		public abstract string InnerHTML();
	}
}
