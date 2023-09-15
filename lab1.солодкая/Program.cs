///высокий уровень
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите t:");
//double t = double.Parse(Console.ReadLine());
//Console.Write("Введите n:");
//double n = double.Parse(Console.ReadLine());
//double s = (4.351 * y * y * y) + (2*t * Math.Log10(t)) / (Math.Sqrt(Math.Cos(2*y)) + 4.351);
//Console.WriteLine($"s={s:F2}");

Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c:");
double c = double.Parse(Console.ReadLine());
double d=((1) / (b+c))*Math.Sqrt(b*c*(a+b+c)*(b + c - a));
Console.WriteLine($"d={d:F2}");