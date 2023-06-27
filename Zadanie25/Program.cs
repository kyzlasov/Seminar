/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
int result = Degree(a, b);

Degree(a,b);
PrintDegree(a,b);

int Degree(int a, int b)
{   
    int step = 1;
    
    for (int i = 0; i < b; i++)
    {   
        step = step * a;
    }
    return step;
}

int PrintDegree(int a, int b)
{
    Console.WriteLine($"Число {a} в степени {b} равно {Degree(a, b)}");
    return result;
}

