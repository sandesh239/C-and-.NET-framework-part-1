using System;

class Program
{
    static void Main()
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight and convert the input to an integer
        Console.WriteLine("Please enter the package weight:");
        int packageWeight = Convert.ToInt32(Console.ReadLine());

        // Check if the weight exceeds the maximum allowed
        if (packageWeight > 50)
        {
            // Display an error message and exit the program if the package is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt the user for the package width
        Console.WriteLine("Please enter the package width:");
        int packageWidth = Convert.ToInt32(Console.ReadLine());

        // Prompt the user for the package height
        Console.WriteLine("Please enter the package height:");
        int packageHeight = Convert.ToInt32(Console.ReadLine());

        // Prompt the user for the package length
        Console.WriteLine("Please enter the package length:");
        int packageLength = Convert.ToInt32(Console.ReadLine());

        // Check if the total dimensions exceed the maximum allowed
        int totalDimensions = packageWidth + packageHeight + packageLength;
        if (totalDimensions > 50)
        {
            // Display an error message and exit the program if the package is too large
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote based on the dimensions and weight
        int dimensionProduct = packageWidth * packageHeight * packageLength;
        decimal shippingCost = (dimensionProduct * packageWeight) / 100m;

        // Display the calculated shipping quote to the user in dollar format
        Console.WriteLine("Your estimated total for shipping this package is: $" + shippingCost.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
