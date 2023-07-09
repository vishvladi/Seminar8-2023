// // Задача 3: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7
int ReadInt(string message)
{
    System.Console.Write(message);  
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}
int[,] GenerateArray2D(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = rnd.Next(min, max);
        }
    }
    return array;
}
void PrintArray2D(int[,] array) //Output array [,] on display
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }  
}
int CheckCorrectInputRowsandColumns(string message)//checking input number on > o
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) return number;
    else
    {
        System.Console.WriteLine("Please, input positive number!");
        return CheckCorrectInputRowsandColumns(message);
    }
}

int array1Rows = CheckCorrectInputRowsandColumns("Input amount of row of array1: ");
int array1Columns = CheckCorrectInputRowsandColumns("Input amount of columns of array1: ");
int array2Rows = CheckCorrectInputRowsandColumns("Input amount of row of array2: ");
int array2Columns = CheckCorrectInputRowsandColumns("Input amount of columns of array2: ");
int randomMin = ReadInt("Input min random number: ");
int randomMax = ReadInt("Input max random number: ");

int[,] randomArray1 = GenerateArray2D(array1Rows, array1Columns, randomMin, randomMax);
int[,] randomArray2 = GenerateArray2D(array2Rows, array2Columns, randomMin, randomMax);
System.Console.WriteLine($"\nYour array1 is: ");
PrintArray2D(randomArray1);
System.Console.WriteLine($"\nYour array2 is:");
PrintArray2D(randomArray2);
System.Console.WriteLine();

int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
     int[,] resultArray = new int[array1Rows, array2Columns];
     for (int i = 0; i < array1.GetLength(0); i++)
     {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultArray[i, j] = sum;
        }
     }
     return resultArray;
} 

int[,] multipliedArray = MultiplyArrays(randomArray1, randomArray2);
System.Console.WriteLine($"\nResult of the multiplication of the arrays: ");
PrintArray2D(multipliedArray);
System.Console.WriteLine();