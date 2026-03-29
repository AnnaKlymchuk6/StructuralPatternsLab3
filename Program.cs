using StructuralPatternsLab.Adapter;
using StructuralPatternsLab.Bridge;
using StructuralPatternsLab.Decorator;
using StructuralPatternsLab.Proxy;
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

			Console.WriteLine("\nЗавдання 3");
			IRenderer vector = new VectorRenderer();
			IRenderer raster = new RasterRenderer();

			Shape circle = new Circle(vector);
			Shape square = new Square(raster);
			Shape triangle = new Triangle(vector);

			circle.Draw();
			square.Draw();
			triangle.Draw();

			Console.WriteLine("\nЗавдання 4");
			ISmartTextReader reader = new SmartTextReader();

			ISmartTextReader checker = new SmartTextChecker(reader);
			checker.Read("test.txt");

			Console.WriteLine();

			ISmartTextReader locker = new SmartTextReaderLocker(reader, "secret");
			locker.Read("secret.txt");
			locker.Read("test.txt");   
		}
	}
}
