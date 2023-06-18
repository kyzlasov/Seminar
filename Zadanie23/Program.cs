Console.Clear();
Console.WriteLine("Введите число сколько раз возвести в куб");
int N = int.Parse(Console.ReadLine());
int i = 1;
if (N < 0){
    Console.WriteLine("Введите положительное число");
}
while (i <= N)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}

