using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	using System.Collections.Generic;

	namespace StructuralPatternsLab.Composite
	{
		class LightElementNode : LightNode
		{
			private string tagName;
			private bool isBlock;
			private bool isSelfClosing;
			private List<string> cssClasses;
			private List<LightNode> children;

			public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
			{
				this.tagName = tagName;
				this.isBlock = isBlock;
				this.isSelfClosing = isSelfClosing;
				this.cssClasses = new List<string>();
				this.children = new List<LightNode>();
			}

			public void AddClass(string className)
			{
				cssClasses.Add(className);
			}

			public void AddChild(LightNode node)
			{
				children.Add(node);
			}

			public override string InnerHTML()
			{
				string result = "";

				foreach (var child in children)
				{
					result += child.OuterHTML();
				}

				return result;
			}

			public override string OuterHTML()
			{
				string classes = "";

				if (cssClasses.Count > 0)
				{
					classes = " class=\"" + string.Join(" ", cssClasses) + "\"";
				}

				if (isSelfClosing)
				{
					return $"<{tagName}{classes}/>";
				}

				return $"<{tagName}{classes}>{InnerHTML()}</{tagName}>";
			}
		}
	}
}
