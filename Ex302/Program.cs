double x1, x2, y1, y2, z1, z2;
Console.WriteLine("Enter x coordinate of first point");
x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of second point");
y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of third point");
z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x coordinate of first point");
x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of second point");
y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of third point");
z2 = double.Parse(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine(result);

