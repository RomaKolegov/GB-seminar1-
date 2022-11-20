/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int userNumber1 = new int ();
Console.Write("Введите первое число: ");
userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = new int ();
Console.Write("Введите второе число: ");
userNumber2 = Convert.ToInt32(Console.ReadLine());
int userNumber3 = new int ();
Console.Write("Введите третье число: ");
userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = userNumber1;
if (userNumber2 > max)
    max = userNumber2;
else if (userNumber3 > max)
        max = userNumber3;
if (userNumber3 > max)
    max = userNumber3;
Console.Write("max = ");
Console.Write(max);