/*

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
string output = "";

if (int.TryParse(input, out int num)) 
{
    num = Math.Abs(num);
    
    if (num < 2)
        output = "Невозможно составить диапазон";

    else
    {
        output = $"Чётные числа в диапазоне от 1 до {num}: ";

        int i = 2;
    
        while (i <= num) {
            
            output += i;
            
            if (i + 2 <= num)
                output += ", ";
            i += 2;
        }
    }
}
else
    output = "Вы ничего не ввели или ввели не число. Выход из программы.";

Console.WriteLine(output);