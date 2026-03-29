using StructuralPatternsLab.Composite;
using StructuralPatternsLab.Composite.StructuralPatternsLab.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Flyweight
{
	class HtmlConverter
	{
		private ElementFactory factory;

		public HtmlConverter(ElementFactory factory)
		{
			this.factory = factory;
		}

		public List<LightNode> Convert(string[] lines)
		{
			List<LightNode> result = new List<LightNode>();

			for (int i = 0; i < lines.Length; i++)
			{
				string line = lines[i];
				string tag;

				if (i == 0)
					tag = "h1";
				else if (line.Length < 20)
					tag = "h2";
				else if (line.StartsWith(" "))
					tag = "blockquote";
				else
					tag = "p";

				LightElementNode element = factory.GetElement(tag);

				LightElementNode newElement = new LightElementNode(tag, true, false);

				newElement.AddChild(new LightTextNode(line));

				result.Add(newElement);
			}

			return result;
		}
	}
}
