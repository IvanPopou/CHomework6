//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223->// 3

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputArray()
{
    int M = Prompt("Введите число элементов массива");
    int[] array = new int[M];

    for(int i = 0; i < M; i++)
    {
        array[i] = Prompt($"Введите число {i+1}");
    }
    return array;
}

int PositiveCounter(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) counter++;
    }
    return counter;
}

int[] massiveM = InputArray();
int positive = PositiveCounter(massiveM);
System.Console.WriteLine($"Количество введенных чисел больше нуля составляет {positive}");