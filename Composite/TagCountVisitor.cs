using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	class TagCountVisitor : IVisitor
	{
		private Dictionary<string, int> counts = new Dictionary<string, int>();

		public void VisitElement(LightElementNode element)
		{
			string tag = element.GetTagName();

			if (!counts.ContainsKey(tag))
			{
				counts[tag] = 0;
			}

			counts[tag]++;
		}

		public void VisitText(LightTextNode textNode)
		{
		}

		public void Print()
		{
			foreach (var pair in counts)
			{
				Console.WriteLine($"{pair.Key}: {pair.Value}");
			}
		}
	}

}
