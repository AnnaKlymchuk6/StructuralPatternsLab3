using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	class HiddenState : IState
	{
		public string Render(LightElementNode element)
		{
			return "";
		}
	}
}
