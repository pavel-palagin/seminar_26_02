// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

double k1 = Promt("Введите k1: ");
double b1 = Promt("Введите b1: ");
double k2 = Promt("Введите k2: ");
double b2 = Promt("Введите b2: ");

double x = ((b2 - b1) / (k1 - k2));
double y = k1 * x + b1;
//y = k2 * x + b2;



Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x}; {y})");

