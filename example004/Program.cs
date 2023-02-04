// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine ("Введите координаты Х первой точки: ");

double X1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Введите координаты Y первой точки: ");

double Y1 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Введите координаты Х второй точки: ");

double X2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Введите координаты Y первой точки: ");

double Y2 = double.Parse(Console.ReadLine() ?? "0");

double Rasst = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2));

Console.WriteLine ("Расстояние между точками: " + Rasst);
