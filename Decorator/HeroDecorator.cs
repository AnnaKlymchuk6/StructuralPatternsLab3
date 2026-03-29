using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab.Decorator
{
	abstract class HeroDecorator : Hero
	{
		protected Hero hero;

		public HeroDecorator(Hero hero)
		{
			this.hero = hero;
		}
	}
}
