using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Composite
{
	class RemoveChildCommand : ICommand
	{
		private LightElementNode parent;
		private LightNode child;

		public RemoveChildCommand(LightElementNode parent, LightNode child)
		{
			this.parent = parent;
			this.child = child;
		}

		public void Execute()
		{
			parent.GetChildren().Remove(child);
		}
	}
}
