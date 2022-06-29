// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
int CheckingForCorrectnes(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Некорректное значение. Для корректной работы программы введите целое число!!!");
        else
        {
            if (number < 0)
                Console.WriteLine("Необходимо ввести положительное число!!!");
            else
                return number;
        }
    }
}
int FunctionAckerman(int m, int n) 
{ 
    if (m==0) return n+1; 
    else if (m>0 && n==0) return FunctionAckerman(m-1, 1); 
    else return FunctionAckerman(m-1, FunctionAckerman(m, n-1)); 
}
int m = CheckingForCorrectnes("Задайте значение M:");
int n = CheckingForCorrectnes("Задайте значение N:");
int result=FunctionAckerman(m,n);
Console.WriteLine($"Значение функции Аккермана при исходных данных M={m} и N={n} равно: {result}");
