// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
        Console.Write("Please enter length: ");
        decimal length = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter height: ");
        decimal height = decimal.Parse(Console.ReadLine()); 


        Console.WriteLine("Area: " + (length * width));
        Console.WriteLine("Perimeter: " + (2 * (length + width)));
        Console.WriteLine("Volume: " + (length * width * height));
        Console.WriteLine("Surface area: " + (2 * ((length * width) + (length * height) + (width * height))));
        switch (length * width)
        {
            case <= 250:
                Console.WriteLine("This is a small-sized room.");
                break;
            case <= 650:
                Console.WriteLine("This is a medium-sized room.");
                break;
            case > 650:
                Console.WriteLine("This is a large-sized room.");
                break;

        }
        Console.WriteLine("Thank you for using the Room Detail Generator!");
    }
}