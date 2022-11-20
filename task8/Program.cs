/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
int userNumber = new int ();
Console.Write("Введите число N: ");
userNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count != userNumber)
    if (userNumber > 0)
        if (count % 2 == 0)
            {
            Console.Write(count);
            Console.Write(", ");
            count = count + 1;
            }
        else count = count + 1;
    else 
        if (count % 2 == 0)
            {
            Console.Write(count);
            Console.Write(", ");
            count = count - 1;
            }
        else count = count - 1;