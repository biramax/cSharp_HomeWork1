/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

Console.Write($"Введите число: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int num)) 
{
    string output = $"Число {num} ";
    
    if (num % 2 == 0) output += "чётное";
    else              output += "нечётное";
    
    Console.WriteLine(output);
}
else
    Console.WriteLine("Вы ничего не ввели или ввели не число. Выход из программы.");
    