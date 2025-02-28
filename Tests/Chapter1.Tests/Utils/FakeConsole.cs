﻿using System.Diagnostics.CodeAnalysis;

namespace Chapter1.Tests.Utils;

[ExcludeFromCodeCoverage]
public static class FakeConsole
{
    public const string TestFileExtension = "consoleStub";

    /// <summary>
    /// To be used only if <see cref="StreamWriter"/> for stub console was used.
    /// Read file of console input by testKey.
    /// </summary>
    public static string ReadAllText(string testKey)
    {
        var output = File.ReadAllText($"{testKey}.{TestFileExtension}");

        return output;
    }

    /// <summary>
    /// To be used only if <see cref="StreamWriter"/> for stub console was used.
    /// Deletes the file for console using testKey.
    /// </summary>
    public static void Cleanup(string testKey)
    {

        File.Delete($"{testKey}.{TestFileExtension}");
    }
}