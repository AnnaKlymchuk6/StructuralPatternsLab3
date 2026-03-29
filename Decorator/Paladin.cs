using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	class Paladin : Hero
	{
		public override string GetDescription()
		{
			return "Paladin";
		}

		public override int GetPower()
		{
			return 12;
		}
	}
}
