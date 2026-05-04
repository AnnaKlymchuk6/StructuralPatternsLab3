using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	class LightElementNode : LightNode
	{
		private string tagName;
		private bool isBlock;
		private bool isSelfClosing;
		private List<string> cssClasses;
		private List<LightNode> children;
		private IState state;

		private Dictionary<string, List<Action>> eventListeners = new Dictionary<string, List<Action>>();

		public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
		{
			this.tagName = tagName;
			this.isBlock = isBlock;
			this.isSelfClosing = isSelfClosing;
			this.cssClasses = new List<string>();
			this.children = new List<LightNode>();
			this.state = new VisibleState();
		}

		protected override void OnCreated()
		{
			Console.WriteLine($"Element <{tagName}> created");
		}

		protected override void OnRendered()
		{
			Console.WriteLine($"Element <{tagName}> rendered");
		}

		public void AddClass(string className)
		{
			cssClasses.Add(className);
		}

		public void AddChild(LightNode node)
		{
			children.Add(node);
		}

		public void AddEventListener(string eventName, Action listener)
		{
			if (!eventListeners.ContainsKey(eventName))
			{
				eventListeners[eventName] = new List<Action>();
			}

			eventListeners[eventName].Add(listener);
		}
		public void TriggerEvent(string eventName)
		{
			if (eventListeners.ContainsKey(eventName))
			{
				foreach (var listener in eventListeners[eventName])
				{
					listener();
				}
			}
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
			return state.Render(this);
		}

		public List<LightNode> GetChildren()
		{
			return children;
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.VisitElement(this);

			foreach (var child in children)
			{
				child.Accept(visitor);
			}
		}
		public string GetTagName()
		{
			return tagName;
		}

		public void SetState(IState state)
		{
			this.state = state;
		}
		public string RenderHtml()
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