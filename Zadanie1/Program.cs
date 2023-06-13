Console.WriteLine("Введите число x и y");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x > y)
Console.WriteLine("Число х > y");
else if (y > x) Console.WriteLine("Число y > x");
else Console.WriteLine("Числа равны");
