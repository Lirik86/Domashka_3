int inpupint(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}
double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
}
int x1 = inpupint("Введите координату x первой точки: ");
int y1 = inpupint("Введите координату y первой точки: ");
int z1 = inpupint("Введите координату z первой точки: ");
int x2 = inpupint("Введите координату x второй точки: ");
int y2 = inpupint("Введите координату y второй точки: ");
int z2 = inpupint("Введите координату z второй точки: ");
System.Console.WriteLine($"Расстояние между точкой А ({x1}, {y1}, {z1}) и точкой В ({x2}, {y2}, {z2}) равно {distance (x1, y1, z1, x2, y2, z2):F2}");