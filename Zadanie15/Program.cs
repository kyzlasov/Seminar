Console.WriteLine("Введите число недели");
int chislo = int.Parse(Console.ReadLine());
if (chislo > 0 && chislo < 6){
    Console.WriteLine("Рабочий день");
}
else if (chislo == 6 || chislo == 7){
    Console.WriteLine("Выходной");
}
else Console.WriteLine("Введено неверное число");