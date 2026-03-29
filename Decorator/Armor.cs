using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	class Armor : HeroDecorator
	{
		public Armor(Hero hero) : base(hero) { }

		public override string GetDescription()
		{
			return hero.GetDescription() + " + Armor";
		}

		public override int GetPower()
		{
			return hero.GetPower() + 7;
		}
	}
}
