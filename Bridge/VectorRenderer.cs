using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Bridge
{
	class VectorRenderer : IRenderer
	{
		public void Render(string shapeName)
		{
			Console.WriteLine($"Drawing {shapeName} as vectors");
		}
	}
}
