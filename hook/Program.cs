


double Coord(int xA, int xB, int yA, int yB, int zA,int zB)
{
    double distance = Math.Sqrt((xA-xB) * (xA - xB) + (yA - yB) * (yA - yB) + (zA -zB) * (zA -zB));
    return distance;
}


Console.WriteLine("Введите координату X для точки А: ");
int x_coord_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х для точки В: ");
int x_coord_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коордиту Y для точки A: ");
int y_coord_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B: ");
int y_coord_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки A: ");
int z_coord_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки B: ");
int z_coord_b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Растояние от точки А до точки В:{Coord(x_coord_a, x_coord_b, y_coord_a, y_coord_b, z_coord_a, z_coord_b)}");
