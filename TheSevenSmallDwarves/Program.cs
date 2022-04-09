// See https://aka.ms/new-console-template for more information

using TheSevenSmallDwarves;

Console.WriteLine("The Seven Small Dwarves");
Console.WriteLine("++++++++++++++++++++++++++\r\n");

for (int i = 0; i < 10; i++)
{
    Story story = new Story();
    story.Run();
    Console.WriteLine("++++++++++++++++++++++++++\r\n");
}

Console.WriteLine("The End!");
Console.ReadKey();