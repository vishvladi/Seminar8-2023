// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
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
int SumElementsOfRows(int[,] array, int i)// Сумма элементов строки
{
     
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    System.Console.WriteLine($"Sum of elements in row {i}: {sum} ");
    return sum;
}
int rowsAmount = CheckCorrectInputRowsandColumns("Input  amount of rows: ");
int columnsAmount = CheckCorrectInputRowsandColumns("Input amount of columns: ");
int randomMin = ReadInt("Input min random number: ");
int randomMax = ReadInt("Input max random number: ");

int[,] randomArray = GenerateArray2D(rowsAmount, columnsAmount, randomMin, randomMax);
System.Console.WriteLine($"\nYour array is: ");
PrintArray2D(randomArray);
System.Console.WriteLine();
int minSumLine = 0;
int sumLine = SumElementsOfRows(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i ++)
{
    int tempSumLine = SumElementsOfRows(randomArray, i);
    if(sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
System.Console.WriteLine($"\nRow number with the smallest sum is: {minSumLine}.");

