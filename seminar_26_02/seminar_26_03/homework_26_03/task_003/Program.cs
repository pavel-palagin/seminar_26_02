// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

double[] RandArray(int lenght)
{
    double[] answer = new double[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = Convert.ToDouble(rand.Next(0, 1000)/10.0);
    }
    return answer;
}


void PrintArray(double[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + "," + " ");
    }
    Console.Write(collect[collect.Length - 1] + "]");
}

double FindMin (double[] array)
{
    double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}
return min;
}

double FindMax (double[] array)
{
    double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
return max;
}

int N = Promt("Введите размер массива: ");
double[] massiv = RandArray(N);

PrintArray(massiv);

Console.WriteLine();
Console.WriteLine($"Минимальный элемент массива равен: {FindMin(massiv)}");
Console.WriteLine($"Минимальный элемент массива равен: {FindMax(massiv)}");

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива, равна: {FindMax(massiv) - FindMin(massiv)}");
