Console.WriteLine("Введите пятизначное число");
int i = int.Parse(Console.ReadLine());
if (i < 10000 || i > 99999) 
{
    Console.WriteLine("Ввели не пятизначное число");

}
if (i / 10000 == i % 10)
{
    if (i/1000%10 == i % 100/10)
    {
        Console.WriteLine("Число палнидром");
    }
    else Console.WriteLine("Число не палиндром");
}
else Console.WriteLine("Число не палиндром");


