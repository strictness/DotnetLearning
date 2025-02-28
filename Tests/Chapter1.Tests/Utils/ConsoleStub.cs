﻿using System.Diagnostics.CodeAnalysis;

namespace Chapter1.Tests.Utils;

[ExcludeFromCodeCoverage]
public static class ConsoleStub
{
    public static StringWriter StubConsole(string readLineReturn)
    {
        var output = new StringWriter();
        Console.SetOut(output);

        var input = new StringReader(readLineReturn);
        Console.SetIn(input);

        return output;
    }
}