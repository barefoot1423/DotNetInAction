using Figgle;
namespace Chapter2;

public static class AsciiArt
{
    public static void Write(Options options)
    {
        WriteLine(FiggleFonts.Standard.Render(options.Text));
        WriteLine("Brought to you by " + typeof(AsciiArt).FullName);
    }
}