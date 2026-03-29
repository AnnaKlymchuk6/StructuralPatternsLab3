using StructuralPatternsLab.Composite;
using StructuralPatternsLab.Composite.StructuralPatternsLab.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Flyweight
{
	class ElementFactory
	{
		private Dictionary<string, LightElementNode> elements = new Dictionary<string, LightElementNode>();

		public LightElementNode GetElement(string tag)
		{
			if (!elements.ContainsKey(tag))
			{
				elements[tag] = new LightElementNode(tag, true, false);
			}

			return elements[tag];
		}

		public int GetCount()
		{
			return elements.Count;
		}
	}
}
