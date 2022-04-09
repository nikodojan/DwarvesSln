// See https://aka.ms/new-console-template for more information

using TheSevenSmallDwarves;


for (int i = 0; i < 3; i++)
{
    Console.Clear();
    Console.WriteLine("The Seven Small Dwarves");
    Console.WriteLine("++++++++++++++++++++++++++\r\n");
    Story story = new Story();
    story.Run();
    Thread.Sleep(5000);
}

Console.WriteLine("The End!");
Console.ReadKey();