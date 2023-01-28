Console.WriteLine("Введите координату x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(D(x1, y1, z1, x2, y2, z2));

double D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double s = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
   return s ;
}