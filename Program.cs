//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//System.Console.Write("Введите первое число (num1): ");
//int num1 = Convert.ToInt32(Console.ReadLine());

 //System.Console.Write("Введите второе число (num2): ");
 //int num2 = Convert.ToInt32(Console.ReadLine());

 //System.Console.WriteLine($"Первое число {num1}, второе число {num2}");

 //if (num1 == num2)
 //{
   //  System.Console.WriteLine($"Числа равны");
 //}
 //else if (num1 > num2)
 //{
   //  System.Console.WriteLine($"Число num1 {num1} больше");
 //}
 //else
 //{
   //  System.Console.WriteLine($"Число num2 {num2} больше");
 //}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//int GetNumber(string welcome)
//{
//     System.Console.Write(welcome);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int num1 = GetNumber("Введите первое число num1: ");
// int num2 = GetNumber("Введите второе число num2: ");
// int num3 = GetNumber("Введите третье число num3: ");

// int max = num1;
// string maxName = "num1";
// if (max < num2)
// {
//     max = num2;
//     maxName = "num2";
// }
// if (max < num3) { max = num3; maxName = "num3"; }

// System.Console.WriteLine($"Максимальное число равно {maxName} {max}");




//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

//int GetNumber(string welcome)
// {
//     System.Console.Write(welcome);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int num = GetNumber("Введите число num: ");

// if (num % 2 == 0) System.Console.WriteLine($"Число num {num} четное");
// else System.Console.WriteLine($"Число num {num} нечетное");



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

// Int GetNumber(string welcome)
// {
//     System.Console.Write(welcome);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num = GetNumber("Введите число num: ");

// int start = 2;
// while (start <= num)
// {
//     System.Console.Write($"{start}");
//     start += 2;
//     if (start <= num)
//     {
//         System.Console.Write(", ");
//     }
// }

