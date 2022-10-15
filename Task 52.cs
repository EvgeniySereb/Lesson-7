


int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random(). Next(0 , 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] InitializateArray(int m, int n)
{
    return new int[m,n];
}
 void Sum( int [,] arr)

{
      double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
            if (j == (arr.GetLength(0) - 1))
            {
                Console.WriteLine($"Среднее арефметическое стобца {i} равно {Math.Round(sum / (j + 1), 1)}");
                sum = 0;
            }
        }
    }
}

int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
Sum( array);