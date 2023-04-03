// // Задача 54: Задайте двумерный массив. 
// // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// // Methods

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SortArray(int[,] sortedArray)
// {
//     for (int i = 0; i < sortedArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < sortedArray.GetLength(1) - 1; j++)
//         {
//             int maxPosition = j;
//             for (int s = j + 1; s < sortedArray.GetLength(1); s++)
//             {
//                 if (sortedArray[i, s] > sortedArray[i, maxPosition])
//                 {
//                     maxPosition = s;
//                 }

//                 int temp = sortedArray[i, j];
//                 sortedArray[i, j] = sortedArray[i, maxPosition];
//                 sortedArray[i, maxPosition] = temp;
//             }

//         }
//     }
//     return sortedArray;
// }


// // Code
// Console.WriteLine("Введите количество строк массива");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns);
// Console.WriteLine("Ваш массив:");
// PrintArray(array);
// Console.WriteLine("Ваш массив c упорядоченными по убыванию элементами каждой строки:");
// PrintArray(SortArray(array));


// //Задача 56: Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// // Method


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] localArray)
// {
//     for (int i = 0; i < localArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < localArray.GetLength(1); j++)
//         {
//             Console.Write($"{localArray[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// int[] FindSumOfElements(int[,] arr)
// {

//     int size = arr.GetLength(0);
//     int[] sumOfElements = new int[size];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum = sum + arr[i, j];
//         }
//         sumOfElements[i] = sum;
//     }
//     return sumOfElements;
// }

// int FindMinPosition(int[] lineOfSums)
// {
//     int minPosition = 0;
//     for (int i = 0; i < lineOfSums.Length; i++)
//     {
//         if (lineOfSums[i] < lineOfSums[minPosition])
//         {
//             minPosition = i;
//         }

//     }
//     return minPosition;
// }


// //Code

// Console.WriteLine("Введите количество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns = int.Parse(Console.ReadLine());
// int[,] myArray = GetArray(rows, columns, 0, 11);
// Console.WriteLine("Ваш массив:");
// PrintArray(myArray);

// Console.WriteLine("Cумма элементов в каждой строке: \n{0}", String.Join("\t", FindSumOfElements(myArray)));

// int[] sumsOfLines = FindSumOfElements(myArray);
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinPosition(sumsOfLines) + 1}");
// Console.WriteLine();

// // // Задача 58 :Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// // // Methods

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FindMatrixProduct(int[,] firstMatr, int[,] secondMatr)
// {
//     int[,] product = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
//     for (int i = 0; i < firstMatr.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMatr.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMatr.GetLength(1); k++)
//             {
//                 sum += firstMatr[i, k] * secondMatr[k, j];
//             }
//             product[i, j] = sum;
//         }
//     }
//     return product;
// }

// // Code
// Console.WriteLine("Введите количество строк первой матрицы");
// int firstMatrixRows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов первой матрицы");
// int firstMatrixColumns = int.Parse(Console.ReadLine());
// int secondMatrixRows = firstMatrixColumns;
// Console.WriteLine("Введите количество столбцов второй матрицы");
// int secondMatrixColumns = int.Parse(Console.ReadLine());
// int[,] firstMatrix = GetArray(firstMatrixRows, firstMatrixColumns);
// Console.WriteLine("Первая матрица:");
// PrintArray(firstMatrix);
// int[,] secondMatrix = GetArray(secondMatrixRows, secondMatrixColumns);
// Console.WriteLine("Вторая матрица:");
// PrintArray(secondMatrix);
// int[,] productArray = FindMatrixProduct(firstMatrix, secondMatrix);
// Console.WriteLine("Произведение двух матриц:");
// PrintArray(productArray);