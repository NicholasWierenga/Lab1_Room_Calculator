// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

        decimal length = getValidDec("Please enter length: ");
        decimal width = getValidDec("Please enter width: ");
        decimal height = getValidDec("Please enter height: ");


        Console.WriteLine("Area: " + getArea(length, width));
        Console.WriteLine("Perimeter: " + getPerimeter(length, width));
        Console.WriteLine("Volume: " + getVolume(length, width, height));
        Console.WriteLine("Surface area: " + getSurfaceArea(length, width, height));
        switch (getArea(length, width))
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

    public static decimal getValidDec(string prompt)
    {
        decimal dec = -1;

        Console.WriteLine(prompt);

        try
        { 
            dec = decimal.Parse(Console.ReadLine());
            if (dec < 0)
            {
                Console.WriteLine("This can't be negative.");
                getValidDec(prompt);
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("This is not a valid decimal number.");
            getValidDec(prompt);
        }

        return dec;
    }

    public static decimal getArea(decimal length, decimal width)
    {
        return length * width;
    }
    public static decimal getPerimeter(decimal length, decimal width)
    {
        return 2 * (length + width);
    }
    public static decimal getVolume(decimal length, decimal width, decimal height)
    {
        return length * width * height;
    }
    public static decimal getSurfaceArea(decimal length, decimal width, decimal height)
    {
        return 2 * ((length * width) + (length * height) + (width * height));
    }
}