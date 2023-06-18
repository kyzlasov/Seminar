Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num <= 99){
    Console.WriteLine("Число меньше ста");
    return;
} 
while (num > 1000)
    num = num/10;
Console.WriteLine($"Третье число {num%10}");
