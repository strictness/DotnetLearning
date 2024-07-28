namespace Wrapper.Console;

public interface IConsole
{
    void WriteLine(string message);
    string? ReadLine();
}