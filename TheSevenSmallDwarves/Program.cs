﻿// See https://aka.ms/new-console-template for more information

using TheSevenSmallDwarves;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, Dwarves!");



for (int i = 0; i < 10; i++)
{
    Story story = new Story();
    story.Run();
    Console.WriteLine("++++++++++++++++++++++++++");
}

//Story story = new Story();
//story.Dwarves.ForEach(d =>
//{
//    d.Act();
//});

//story.Run();

Console.WriteLine("The End!");
Console.ReadKey();