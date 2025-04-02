using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiates the application with a welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Captures the package weight from the user
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Examines if the package weight is within acceptable range
            if (weight > 50)
            {
                // Alerts the user that the package exceeds weight limitations
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Halts execution due to weight constraint violation
            }

            // Obtains the width dimension of the package
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Obtains the height dimension of the package
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Obtains the length dimension of the package
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Verifies if the combined dimensions are within shipping limits
            if (width + height + length > 50)
            {
                // Communicates that the package size exceeds shipping capabilities
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Concludes program due to size limitations
            }

            // Derives the shipping cost based on package metrics
            float quote = (height * width * length * weight) / 100;

            // Outputs the calculated shipping price to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Prevents the console from closing immediately
            Console.ReadKey();
        }
    }
}