//Найдите максимальное значение в матрице по каждой строке, 
//получите сумму этих максимумов. 
//Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix()
{
    int Rows = Prompt("Введите количество строк в матрице");
    int Columns = Prompt("Введите количество столбцов в матрице");
    int min = Prompt("Введите минимальный порог случайных значений");
    int max = Prompt("Введите максимальный порог случайных значений");
    int[,] matrix = new int[Rows, Columns];
    
    for(int i = 0; i < Rows; i++)
    {
        for(int j = 0; j < Columns; j++)
        {
            matrix[i,j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
    System.Console.WriteLine();
    }
}

int FindMax(int[,] matrix)
{
    int maxsumm = 0;
    int localmax = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        localmax = matrix[i,0];
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] > localmax) localmax = matrix[i,j];
        }
        maxsumm = maxsumm + localmax;
    }
    return maxsumm;
}

int FindMin(int[,] matrix)
{
    int minsumm = 0;
    int localmin = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        localmin = matrix[0,i];
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            if(matrix[j,i] < localmin) localmin = matrix[j,i]; 
        }
        minsumm = minsumm + localmin;
    }

    return minsumm;
}

int[,] newmatrix = GenerateMatrix();
PrintMatrix(newmatrix);
int max = FindMax(newmatrix); 
System.Console.WriteLine($"Сумма максимумов по каждой строке {max}");
int min = FindMin(newmatrix); 
System.Console.WriteLine($"Сумма минимумов по каждому столбцу {min}");
int diff = max-min;
System.Console.WriteLine($"Результат вычисления равен {diff}");