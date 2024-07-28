using System.Diagnostics.CodeAnalysis;
using Wrapper.Console;

namespace Homework1and2;

public static class Program
{
    [ExcludeFromCodeCoverage]
    public static void Main()
    {
        var console = new SystemConsole();
        var inputsDictionary = ReadInputs(console);
        PrintInformation(console, inputsDictionary);
    }
    
    public static Dictionary<string, string> ReadInputs(IConsole console)
    {
        var inputs = new Dictionary<string, string>();
        console.WriteLine("Enter your name:");
        inputs["name"] = console.ReadLine() ?? throw new ArgumentException("Name cannot be null");
        console.WriteLine("Enter your surname:");
        inputs["surname"] = console.ReadLine() ?? throw new ArgumentException("Surname cannot be null");
        console.WriteLine("Enter your age:");
        inputs["age"] = console.ReadLine() ?? throw new ArgumentException("Age cannot be null");
        console.WriteLine("Enter your weight (in kg):");
        inputs["weight"] = console.ReadLine() ?? throw new ArgumentException("Weight cannot be null");
        console.WriteLine("Enter your height (in cm):");
        inputs["height"] = console.ReadLine() ?? throw new ArgumentException("Height cannot be null");
        return inputs;
    }

    public static void PrintInformation(IConsole console, Dictionary<string, string> inputsDictionary)
    {
        var name = inputsDictionary["name"];
        var surname = inputsDictionary["surname"];
        var age = inputsDictionary["age"];
        var weight = inputsDictionary["weight"];
        var height = inputsDictionary["height"];
        console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
        var bmi = GetBMI(weight, height);
        console.WriteLine($"Body-mass index (BMI) is: {bmi}");
    }
    
    public static double GetBMI(string weightInKilograms, string heightInCentimeters)
    {
        var weight = double.Parse(weightInKilograms);
        var height = double.Parse(heightInCentimeters) / 100;
        var bmi = weight / (height * height);
        return Math.Round(bmi, 2);
    }
}