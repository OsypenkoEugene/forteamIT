{
    Console.WriteLine("Enter coordinate x for dot A:");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter coordinate y for dot A:");
    double y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter coordinate x1 for dot B:");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter coordinate y1 for dot B:");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter coordinate x2 for dot C:");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter coordinate y2 for dot C:");
    double y2 = Convert.ToDouble(Console.ReadLine());
    double AB = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));
    AB = Convert.ToInt32(AB);
    Console.WriteLine($"Length of AB is: {AB}");
    double BC = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine($"Length of BC is: {BC}");
    double AC = Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((y2 - y), 2));
    AC = Convert.ToInt32(AC);
    Console.WriteLine($"Length of AC is: {AC}");
    double P = AB + BC + AC;
    Console.WriteLine($"Perimeter is: {P}");
    if (AB == BC && BC == AC && AB==AC)
    {
        Console.WriteLine($"Triangle is equilateral");
    }
    else
    {
        Console.WriteLine($"Triangle is not equilateral");
    }
        if (AB == AC)
        {
            Console.WriteLine($"Triangle is isosceles");
        }
        else
        {
            Console.WriteLine($"Triangle is not isosceles");
        }
        if (AB * AB + BC * BC == AC * AC && BC * BC + AC * AC == AB * AB && AC * AC + AB * AB == BC * BC)
        {
            Console.WriteLine($"Triangle is right");
        }
       else
       {
        Console.WriteLine($"Triangle is not right");
       }
    Console.WriteLine($"Parity numbers in range from 0 to triangle perimetr:");
    for (int i = 0; i <=(P); i += 2) Console.WriteLine(i);
        Console.ReadLine();
 }

        