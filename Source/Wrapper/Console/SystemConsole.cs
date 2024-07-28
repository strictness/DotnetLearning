using System.Diagnostics.CodeAnalysis;

namespace Wrapper.Console;

[ExcludeFromCodeCoverage]
public class SystemConsole : IConsole
{
    public void WriteLine(string message)
    {
        System.Console.WriteLine(message);
    }

    public string? ReadLine()
    {
        return System.Console.ReadLine();
    }
}