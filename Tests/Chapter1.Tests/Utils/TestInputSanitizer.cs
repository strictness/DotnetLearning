using System.Diagnostics.CodeAnalysis;

namespace Chapter1.Tests.Utils;

[ExcludeFromCodeCoverage]
public static class TestInputSanitizer
{
    public static string[] ToNewlineSentences(this string message) => message.Split(".");
}