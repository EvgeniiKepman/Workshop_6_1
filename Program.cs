// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 5
// 0
// 7
// 8
// -2
// -2 -> 2

// 5
// 1
// -7
// 567
// 89
// 223-> 3

Console.Clear();

Console.WriteLine("Введите колличество чисел: ");
string input1 = Console.ReadLine();
int limit = int.Parse(input1);

int count = 0;
int n = 0;

while (n < limit){
    Console.WriteLine("Введите число: ");
    string input2 = Console.ReadLine();
    int number = int.Parse(input2);

    if(number > 0){
        count = count + 1;
    }
    n++;
}
Console.WriteLine($"Колличество положительных чисел - {count}.");
