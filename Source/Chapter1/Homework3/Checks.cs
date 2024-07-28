namespace Homework3
{
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var stringInput = Console.ReadLine();

            if (!int.TryParse(stringInput, out var intInput)) throw new ArgumentException("Invalid input. Please enter a number.");
            return intInput;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var stringInput = Console.ReadLine() ?? throw new ArgumentException("Invalid input. Please enter a string.");
            
            return stringInput;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var stringInput = Console.ReadLine();

            if (!float.TryParse(stringInput, out var floatInput)) throw new ArgumentException("Invalid input. Please enter a number.");
            return floatInput;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height == 0) throw new ArgumentException("Height cannot be 0.");
            return weight / (height * height);
        }
    }
}