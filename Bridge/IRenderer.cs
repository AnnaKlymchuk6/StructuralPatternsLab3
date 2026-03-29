using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Bridge
{
	interface IRenderer
	{
		void Render(string shapeName);
	}
}
