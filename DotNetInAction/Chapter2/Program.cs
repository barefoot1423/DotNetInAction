using Chapter2;

if (args.Length == 0)
{
    Console.WriteLine("Usage: HelloDotnet <text>");
    Environment.Exit(1);
}

AsciiArt.Write(args[0]);