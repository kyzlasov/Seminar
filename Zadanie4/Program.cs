Console.WriteLine("Задайте положительное число");
int num = int.Parse(Console.ReadLine());
int count = 2;
while (count < num)
{
    if (num % 2 == 0)
    Console.WriteLine(count);
    count = count + 2;
}
