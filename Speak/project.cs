using System;
using Speak;

class Project 
{
    static void Main()
    {
        Console.WriteLine("Translate to code language");
        string input = Console.ReadLine();
        LeetspeakTranslator translator = new LeetspeakTranslator(input);
        Console.WriteLine(translator.Translate());
    }
}