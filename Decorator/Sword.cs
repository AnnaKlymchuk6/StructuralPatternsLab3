using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	class Sword : HeroDecorator
	{
		public Sword(Hero hero) : base(hero) { }

		public override string GetDescription()
		{
			return hero.GetDescription() + " + Sword";
		}

		public override int GetPower()
		{
			return hero.GetPower() + 5;
		}
	}
}
