using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	class Mage : Hero
	{
		public override string GetDescription()
		{
			return "Mage";
		}

		public override int GetPower()
		{
			return 8;
		}
	}
}
