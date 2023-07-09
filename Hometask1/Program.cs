/*  Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void PrintArray2D(int[,] array)  
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
int CheckCorrectInputRowsandColumns(string message) 
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
int[,] OrderByDescRowsElements(int[,] array) 
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) -1; k++)
            {   
                if (array[i, k] < array[i, k +1])
                {   
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp; 
                } 
            }
        }
    }
    return array;
}
int rowsAmount = CheckCorrectInputRowsandColumns("Input count row: ");
int columnsAmount = CheckCorrectInputRowsandColumns("Input count columns: ");
int randomMin = ReadInt("Input min random number: ");
int randomMax = ReadInt("Input max random number: ");

int[,] randomArray = GenerateArray2D(rowsAmount, columnsAmount, randomMin, randomMax);
System.Console.WriteLine($"\nYour array is: ");
PrintArray2D(randomArray);
System.Console.WriteLine();
System.Console.WriteLine($"\nArray with rows order by desc.: ");
OrderByDescRowsElements(randomArray);
PrintArray2D(randomArray);
System.Console.WriteLine();




