using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	class Warrior : Hero
	{
		public override string GetDescription()
		{
			return "Warrior";
		}

		public override int GetPower()
		{
			return 10;
		}
	}
}
