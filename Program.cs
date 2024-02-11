// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"



// void PrintNaturalNumbers(int N, int M = 1)
// {
//     if (M <= N)
//     {
//         Console.Write(M);
//         if (M < N) // Добавляем запятую после каждого числа кроме последнего
//         {
//             Console.Write(", ");
//         }
//         PrintNaturalNumbers(N, M + 1);
//     }
//     else
//     {
//         Console.WriteLine(); // Избавляюсь от символа % в конце вывода (macOS)
//     }
// }
// PrintNaturalNumbers(9, 6);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 29

// int Ackermann(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ackermann(n - 1, 1);
//     }
//     return Ackermann(n - 1, Ackermann(n, m - 1));
// }
// Console.WriteLine(Ackermann(1, 2));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

// void PrintElementsArrayFromEnd(int[] array, int index)
// {
//     if (index < 0)
//     {
//         return;
//     }

//     PrintElementsArrayFromEnd(array, index - 1);
//     Console.Write(array[index] + " ");
// }

// int[] arr = new int[] { 1, 2, 5, 0, 10, 34 };
// PrintElementsArrayFromEnd(arr, arr.Length - 1);
// Console.WriteLine();