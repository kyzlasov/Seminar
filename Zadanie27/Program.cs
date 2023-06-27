/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/
Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int result = Suma(i);
Console.WriteLine(result);


int Suma(int i)
{
    int sum = 0;
    while( i >  0)
    {
        int num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
    return sum;
}





