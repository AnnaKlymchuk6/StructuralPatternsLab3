using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	class LightTextNode : LightNode
	{
		private string text;

		public LightTextNode(string text)
		{
			this.text = text;
		}

		public override string OuterHTML()
		{
			return text;
		}

		public override string InnerHTML()
		{
			return text;
		}
	}
}
