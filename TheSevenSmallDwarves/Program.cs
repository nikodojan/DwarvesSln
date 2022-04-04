// See https://aka.ms/new-console-template for more information

using TheSevenSmallDwarves;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, Dwarves!");

Story story = new Story();

story.Dwarves.ForEach(d=> { Console.WriteLine(d); });

Console.WriteLine("The End!");
Console.ReadKey();