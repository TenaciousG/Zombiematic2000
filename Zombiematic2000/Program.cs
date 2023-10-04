
Console.WriteLine("welcome");



var fin = false;
while (fin == false)
{
    Console.WriteLine("ask me anything");

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    //Console.BackgroundColor = ConsoleColor.DarkMagenta;
    var question = Console.ReadLine();


    if (question.Contains("quit"))
    {
        fin = true;
    }

    else if (question.Contains("who"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("the master of the universe (:");
    }
    else if (question.StartsWith("is"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("i dont know but maybe it is related to saussages with mayo");
    }
    else if (question.Contains("how"))
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("i dont think your ready to know little human");
    }
    else if (question.StartsWith("can"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("yes of course");
    }
    else if (question.Contains(" i "))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("a silly little human");
    }
    else if (question.Contains("name"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("i wish it was Bob poo Face");
    }
    else if (question.Contains("where"))
    {
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("toilet street");
    }
    else if (question.Contains("why"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("because i have a big but");
    }
    else if (question.Contains("when"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("to morrow at 00:00 (:");
    }

//are you
//am i
//will
//should
//now
    else if (question.Contains("now"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("ok (:");
    }
    else if (question.Contains("should"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("or maybe a toilet seat");
    }
    else if (question.StartsWith("will"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("i dont know but maybe it is saussages with mayo");
    }
    else if (question.StartsWith("am i"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("yes or maybe not (:");
    }
    else if (question.StartsWith("are you"))
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("maybe");
    }



    else if (question.Contains("what"))
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("sausages with mayo");
    }

    else if (question.Contains("beep"))
    {
        Console.WriteLine("pls type a number");
        var freq = Console.ReadLine();
        Console.Beep(int.Parse(freq), 2000);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine("i am sorry i dont know ):");

    }
}





Console.WriteLine("bye");
Console.ReadLine();