Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int posl = num % 10;
Console.WriteLine($"Последняя цифра {posl}");
