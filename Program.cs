using StructuralPatternsLab.Adapter;
using StructuralPatternsLab.Bridge;
using StructuralPatternsLab.Composite;
using StructuralPatternsLab.Composite.StructuralPatternsLab.Composite;
using StructuralPatternsLab.Decorator;
using StructuralPatternsLab.Flyweight;
using StructuralPatternsLab.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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


			Console.WriteLine("\nЗавдання 5");

			// <ul>
			LightElementNode ul = new LightElementNode("ul", true, false);

			// <li>Hello</li>
			LightElementNode li1 = new LightElementNode("li", true, false);
			li1.AddChild(new LightTextNode("Hello"));

			// <li>World</li>
			LightElementNode li2 = new LightElementNode("li", true, false);
			li2.AddChild(new LightTextNode("World"));

			// додаємо в ul
			ul.AddChild(li1);
			ul.AddChild(li2);

			// вивід
			Console.WriteLine(ul.OuterHTML());



			Console.WriteLine("\nЗавдання 6");

			// читаємо файл
			string[] lines = File.ReadAllLines("book.txt");

			// створюємо фабрику
			ElementFactory factory = new ElementFactory();

			// конвертер
			HtmlConverter converter = new HtmlConverter(factory);

			// створюємо HTML
			var html = converter.Convert(lines);

			// вивід HTML
			foreach (var node in html)
			{
				Console.WriteLine(node.OuterHTML());
			}

			// показуємо "економію"
			Console.WriteLine($"\nУнікальних елементів (Flyweight): {factory.GetCount()}");
			Console.WriteLine($"Загальна кількість рядків: {html.Count}");
		}
	}
}
