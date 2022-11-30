/*

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

bool error = false;
string input = "";
int i = 0;
int max = 0;
string index = "";

while (i < 3) 
{
    switch (i)
    {
        case 0: index = "первое"; break;
        case 1: index = "второе"; break;
        case 2: index = "третье"; break;
    }
    
    Console.Write($"Введите {index} число: ");
    input = Console.ReadLine() ?? "";
    
    if (int.TryParse(input, out int num)) 
    {
        if (num > max)
            max = num;
    }
    else
    {
        error = true;
        break;
    }

    i ++;
}

if (error)
    Console.WriteLine("Вы ничего не ввели или ввели не число. Выход из программы.");
else
    Console.WriteLine($"Максимальное число из введённых: {max}");