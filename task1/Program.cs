/*

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine() ?? "";

bool error = false;
string output = "";

if (int.TryParse(input1, out int num1)) 
{
    Console.Write("Введите второе число: ");
    string input2 = Console.ReadLine() ?? "";

    if (int.TryParse(input2, out int num2)) 
    {
        if (num1 > num2)       output = $"Первое число ({num1}) больше второго ({num2})";
        else if (num1 < num2)  output = $"Второе число ({num2}) больше первого ({num1})";
        else                   output = $"Первое число ({num1}) равно второму ({num2})";
    }
    else
        error = true;
}
else
    error = true;

if (error)
    Console.WriteLine("Вы ничего не ввели или ввели не число. Выход из программы.");
else
    Console.WriteLine(output);