Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num1 = num / 10;
int num2 = num1 % 10;
Console.WriteLine($"Второе число = {num2}");
