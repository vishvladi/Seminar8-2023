// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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


int[,] FillSpiralArray(int arraySize)
{
    int[,] array = new int[arraySize, arraySize];
    int rowBeg = 0, rowFin = 0, columnBeg = 0, columnFin = 0;
    int row = 0, column = 0, stepNumber = 0;
    while (stepNumber < array.Length)
    {
        array[row, column] = stepNumber;
        if(row == rowBeg && column < arraySize - columnFin -1)
            column ++;
        else if (column == arraySize - columnFin - 1 && row < arraySize - columnFin - 1)
            row ++;
        else if (row == arraySize - rowFin - 1 && column > columnBeg)
            column --;
        else
            row --;
        if ((row == rowBeg + 1) && (column == columnBeg) && (columnBeg != arraySize - columnFin -1))
        {
            rowBeg ++;
            rowFin ++;
            columnBeg ++;
            columnFin ++;
        }
        stepNumber ++;
    }
    return array;
}

int inputArraySize = CheckCorrectInputRowsandColumns("Input size for spiral square array: ");
System.Console.WriteLine();
int[,] array = FillSpiralArray(inputArraySize);
PrintArray2D(array);
System.Console.WriteLine();
