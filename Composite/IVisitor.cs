using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	interface IVisitor
	{
		void VisitElement(LightElementNode element);
		void VisitText(LightTextNode textNode);
	}
}
