using StructuralPatternsLab.Adapter;
using StructuralPatternsLab.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatternsLab
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Завдання 1");

			ILogger logger;

			logger = new Logger();
			logger.Log("Console log");
			logger.Error("Console error");
			logger.Warn("Console warning");

			logger = new FileLoggerAdapter("log.txt");
			logger.Log("File log");
			logger.Error("File error");
			logger.Warn("File warning");

			Console.WriteLine("\nЗавдання 2");
			Hero hero = new Warrior();

			hero = new Sword(hero);
			hero = new Armor(hero);
			hero = new Ring(hero);

			Console.WriteLine(hero.GetDescription());
			Console.WriteLine("Power: " + hero.GetPower());
		}
	}
}
