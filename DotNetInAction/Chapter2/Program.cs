using Chapter2;
using CommandLine;

Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(AsciiArt.Write)
    .WithNotParsed( _ =>
        WriteLine("Usage: HelloDotnet <text> --font big"));