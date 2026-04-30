using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	abstract class LightNode
	{
		public string Render()
		{
			OnCreated();
			string result = OuterHTML();
			OnRendered();
			return result;
		}
		protected virtual void OnCreated() { }
		protected virtual void OnRendered() { }

		public abstract string OuterHTML();
		public abstract string InnerHTML();
	}
}
