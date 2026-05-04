using StructuralPatternsLab.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Strategy
{
	class ImageNode : LightNode
	{
		private string href;
		private IImageStrategy strategy;

		public ImageNode(string href)
		{
			this.href = href;

			if (href.StartsWith("http"))
			{
				strategy = new NetworkImageStrategy();
			}
			else
			{
				strategy = new FileImageStrategy();
			}
		}

		public override string OuterHTML()
		{
			string content = strategy.LoadImage(href);
			return $"<img src=\"{href}\" alt=\"{content}\" />";
		}

		public override string InnerHTML()
		{
			return "";
		}

		public override void Accept(IVisitor visitor)
		{
		}
	}
}
