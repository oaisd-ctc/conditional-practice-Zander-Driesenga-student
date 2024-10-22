
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        CheckForPositiveNegativeZero(0);
        FindMinimum(14, 15, 5);
        FindMaximum(17, 56, 20);
        IsDivisibleBy5(8);
        CheckEvenOrOdd(5);
        CheckVowelOrConsonant('e');
        // Test your functions by calling them below:
        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"
    }

    public static void FindMinimum(int v1, int v2, int v3)
    {
        int numberOne = Math.Min(v1, v2);
        int numberTwo = Math.Min(v3, numberOne);
        Console.WriteLine(numberTwo);
    }
    public static void IsDivisibleBy5(int number)
    {
        int answer = number % 5;
        if (answer == 0)
        {
            Console.WriteLine($"{number} is divisible by 5");
        }
        else 
        {
            Console.WriteLine($"{number} is not divisible by 5");
        }
    }
    public static void CheckVowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine($"{letter} is a vowel");
                break;
        }
    }
    public static void CheckEvenOrOdd(int number)
    {
        int answer = number % 2;
        if (answer == 0)
        {
            Console.WriteLine($"{number} is an even number");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number");
        }
    }
    public static void FindMaximum(int v1, int v2, int v3)
    {
        int numberOne = Math.Max(v1, v2);
        int numberTwo = Math.Max(v3, numberOne);
        Console.WriteLine(numberTwo);
    }
    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }
    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("Your number is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Your number is negative");
        }
        else
        {
            Console.WriteLine("Your number is zero");
        }
    }
    // Define your functions below:

}
