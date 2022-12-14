//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2 - b1) / (k1 - k2)
// y = k1 * (b2 - b1) / (k1 - k2) + b1 

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] angle =  {Prompt("Введите k1"), 
                Prompt("Введите k2")};
int[] offset = {Prompt("Введите b1"), 
                Prompt("Введите b2")};

if(angle[1] != angle[0])
{
    double[] point = new double[2];
    point[0] = (double)(offset[1] - offset[0]) 
               / (double)(angle[0] - angle[1]);
    point[1] = (double)angle[0] * point[0] 
               + (double)offset[0];
    
    System.Console.WriteLine($"Координаты точки пересечения прямых ({point[0]}, {point[1]})");
}
else 
{
    System.Console.WriteLine($"Решения не существует");
}
