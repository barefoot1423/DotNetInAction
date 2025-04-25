using Figgle;

if (args.Length == 0)
{
    Console.WriteLine("Usage: HelloDotnet <text>");
    Environment.Exit(1);
}

Console.WriteLine(FiggleFonts.Standard.Render(args[0]));