using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	class Ring : HeroDecorator
	{
		public Ring(Hero hero) : base(hero) { }

		public override string GetDescription()
		{
			return hero.GetDescription() + " + Ring";
		}

		public override int GetPower()
		{
			return hero.GetPower() + 3;
		}
	}
}
