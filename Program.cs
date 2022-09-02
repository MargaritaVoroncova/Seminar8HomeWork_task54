/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           for(int k = j + 1; k < array.GetLength(1); k++)
           {
             if(array[i,j] < array[i,k])
            {
                int temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
            }
           }
        }
    }
}

//задаем рандомом количество строк и столбцов массива
int rows = new Random().Next(2,10);
int columns = new Random().Next(2,10);

//заполняем массив случайными числами и выводим на экран
int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

SortArray(array);
PrintArray(array);