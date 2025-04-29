using CommandLine;

namespace Chapter2;

public record Options
{
    private string? _text;
    
    [Value(0, Required = true)]
    public string? Text
    {
        get => _text;
        set => _text = value;
    }
};