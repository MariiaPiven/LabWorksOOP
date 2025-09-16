using System;


class Program
{
    static void Main()
    {
        double perimeter = 0;
        while (true)
        {
            Console.Write("Введіть периметр рівностороннього трикутника: ");
            string? input = Console.ReadLine();
            if (input != null && double.TryParse(input, out perimeter) && perimeter > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Хибно введений периметр! Введіть додатне число.");
            }
        }


        double side = perimeter / 3;
        double area = (Math.Sqrt(3) / 4) * side * side;
        Console.WriteLine($"Площа трикутника: {area:F4}");
    }
}
