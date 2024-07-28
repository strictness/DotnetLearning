namespace Homework3
{
    public class Program
    {
        public static void Main()
        {
            Demo();
        }
        
        private static void Demo()
        {
            var name = Checks.PromptString("Enter your name:");
            var surname = Checks.PromptString("Enter your surname:");
            var age = Checks.PromptInt("Enter your age:");
            var weight = Checks.PromptFloat("Enter your weight (in kg):");
            var height = Checks.PromptFloat("Enter your height (in cm):");
            var bmi = Checks.CalculateBmi(weight, height);
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"Body-mass index (BMI) is: {bmi}");
        }
    }
}