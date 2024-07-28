namespace Chapter1.Tests.Utils
{
    public static class TestInputSanitizer
    {
        public static string[] ToNewlineSentences(this string message) => message.Split(".");
    }
}