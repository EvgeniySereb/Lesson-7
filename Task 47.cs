


int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double GetMaxMin(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double GetRandomValue(double minValue , double maxValue)
{
    return  minValue +(Math.Round (new Random().NextDouble() *(maxValue - minValue) , 1 ));
}

void FillArray(double[,] arr, double minValue, double maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue , maxValue) ;
        }
    }
}

void PrintArray(double[,] arr)
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

double[,] InitializateArray(int m, int n)
{
    return new double[m,n];
}


int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
double[,] array = InitializateArray(m,n);
double minValue = GetMaxMin("Введите минимальное число, допустимое в массиве");
double maxValue = GetMaxMin("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);

PrintArray(array);
