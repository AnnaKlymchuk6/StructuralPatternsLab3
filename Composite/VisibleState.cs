using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	class VisibleState : IState
	{
		public string Render(LightElementNode element)
		{
			return element.RenderHtml();
		}
	}
}
