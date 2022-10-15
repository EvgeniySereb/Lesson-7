


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
            arr[i,j] = new Random(). Next(0 , 100);
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
 void GetPosition( int x , int y ,  int [,] arr)
{

    
    
        if ((x <  arr.GetLength(0) && x >= 0) || (y < arr.GetLength(1) && y >= 0))
        {
            Console.WriteLine($"элемент с индексом {x} , {y} = {arr[x , y]}");
        }
        else 
        {
             Console.WriteLine("Элемента с таким индексом не существует");
        }
    }



int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
int x = GetNumberFromConsole("Введите позицию элемента m");
int y = GetNumberFromConsole("Введите позицию элемента n");
GetPosition(x , y , array);