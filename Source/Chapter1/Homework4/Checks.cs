namespace Homework4
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var stringInput = Console.ReadLine();
            if (int.TryParse(stringInput, out var intInput)) return intInput;
            Console.WriteLine($"input \"{stringInput}\", errorMessage: \"{stringInput}\" is not a valid number.");
            return -1;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) return input;
            Console.WriteLine("Name cannot be empty.");
            return "-";
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var stringInput = Console.ReadLine();
            if (float.TryParse(stringInput, out var floatInput)) return floatInput;
            Console.WriteLine($"input \"{stringInput}\", errorMessage: \"{stringInput}\" is not a valid number.");
            return -1;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (!(height <= 0) && !(weight <= 0)) return weight / (height * height);
            Console.WriteLine("Failed calculating BMI. Reason:");
            if (height <= 0) Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
            if (weight <= 0) Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
            return -1;
        }
    }
}