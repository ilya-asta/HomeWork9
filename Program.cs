// ________________Домашняя работа__________________________
// ____________________Задание 1____________________________

//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int endNum=1;
// System.Console.WriteLine(PrintNumbers(num, endNum));

// string PrintNumbers(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         return num1.ToString();
//     }
//     return(num1 + " " + PrintNumbers(num1-1,num2));
// }



// ________________________Задание 2_____________________

//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N большее М: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = SumFromMToN(m, n);
// Console.WriteLine("Сумма натуральных элементов от M до N: " + sum);


// int SumFromMToN(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else
//     {
//         return m + SumFromMToN(m + 1, n);
//     }
// }




// _________________________________Задание 3___________________________
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.WriteLine("Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Akkerman(numM, numN));


// int Akkerman( int numM, int numN)
// {
//     if (numM == 0)
//     {
//         return numN + 1;
//     }
//     else if (numN == 0 && numM > 0)
//     {
//         return Akkerman(numM - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(numM - 1, Akkerman(numM, numN - 1)));
//     }
// }

