
// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Некорректное значение. Для корректной работы программы введите натуральное число!!!");
        else
        {
            if (number < 0)
                Console.WriteLine("Необходимо ввести натуральное число!!!");
            else
                return number;
        }
    }
}
int SumElements(int number1, int number2)
{
    if (number1 == number2) return number1;
    else return number2 + SumElements(number1, number2 - 1);
}
int m = CheckingForCorrectnes("Введите натуральное число M:");
int n = CheckingForCorrectnes("Введите натуральное число N:");
int result;
if (n > m)
{
    result = SumElements(m, n);
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна: {result}");
}
else
{
    result = SumElements(n, m);
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {n} до {m} равна: {result}");
}