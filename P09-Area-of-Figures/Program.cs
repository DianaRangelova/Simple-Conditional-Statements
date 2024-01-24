string figureType = Console.ReadLine();

// Option 2 here: double area = 0;

if (figureType == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;

    Console.WriteLine($"{area:F2}");

    // Option 2 here without: Console.WriteLine($"{area:F2}");
}
else if (figureType == "rectangle")
{

    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());
    double area = width * length;

    Console.WriteLine($"{area:F2}");

    // Option 2 here without: Console.WriteLine($"{area:F2}");
}
else if (figureType == "circle")
{
    double radus = double.Parse(Console.ReadLine());
    double area = radus * radus * Math.PI;

    Console.WriteLine($"{area:F2}");

    // Option 2 here without: Console.WriteLine($"{area:F2}");
}
// Option 2 here: Console.WriteLine($"{area:F2}");
