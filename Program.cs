using StructuralPatternsLab.Adapter;
using StructuralPatternsLab.Bridge;
using StructuralPatternsLab.Composite;
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

			LightElementNode ul = new LightElementNode("ul", true, false);

			LightElementNode li1 = new LightElementNode("li", true, false);
			li1.AddChild(new LightTextNode("Hello"));

			LightElementNode li2 = new LightElementNode("li", true, false);
			li2.AddChild(new LightTextNode("World"));

			ICommand add1 = new AddChildCommand(ul, li1);
			ICommand add2 = new AddChildCommand(ul, li2);

			add1.Execute();
			add2.Execute();

			Console.WriteLine(ul.Render());
			Console.WriteLine(li1.Render());
			Console.WriteLine(li2.Render());

			Console.WriteLine("\nIterator:");

			var iterator = new DepthFirstIterator(ul);

			while (iterator.HasNext())
			{
				var node = iterator.Next();
				Console.WriteLine(node.OuterHTML());
			}

			Console.WriteLine("\nVisitor:");

			var visitor = new TagCountVisitor();
			ul.Accept(visitor);
			visitor.Print();

			Console.WriteLine("\nState:");

			li2.SetState(new HiddenState());
			Console.WriteLine(ul.Render());

			Console.WriteLine("\nObserver:");

			var button = new LightElementNode("button", true, false);
			button.AddChild(new LightTextNode("Click me"));

			button.AddEventListener("click", () =>
			{
				Console.WriteLine("Button clicked!");
			});

			button.AddEventListener("mouseover", () =>
			{
				Console.WriteLine("Mouse over!");
			});

			Console.WriteLine(button.Render());

			Console.WriteLine("\nTrigger click:");
			button.TriggerEvent("click");

			Console.WriteLine("\nTrigger mouseover:");
			button.TriggerEvent("mouseover");


			//		Console.WriteLine("\nЗавдання 6");
			//		string[] lines = File.ReadAllLines("book.txt");

			//		ElementFactory factory = new ElementFactory();

			//		HtmlConverter converter = new HtmlConverter(factory);

			//		var html = converter.Convert(lines);

			//		foreach (var node in html)
			//		{
			//			Console.WriteLine(node.OuterHTML());
			//		}

			//		Console.WriteLine($"\nУнікальних елементів (Flyweight): {factory.GetCount()}");
			//		Console.WriteLine($"Загальна кількість рядків: {html.Count}");
			//	}
		}
	}
}
