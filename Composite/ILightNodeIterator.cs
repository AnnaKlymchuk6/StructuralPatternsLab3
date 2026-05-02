using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	interface ILightNodeIterator
	{
		bool HasNext();
		LightNode Next();
	}
}
