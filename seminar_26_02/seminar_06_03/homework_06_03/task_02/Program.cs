// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int x1 = Prompt("Координата х первой точки: ");
int y1 = Prompt("Координата у первой точки: ");
int z1 = Prompt("Координата z первой точки: ");
int x2 = Prompt("Координата х второй точки: ");
int y2 = Prompt("Координата у второй точки: ");
int z2 = Prompt("Координата z второй точки: ");

int x = x1 - x2;
int y = y1 - y2;
int z = z1 - z2;

double d = Math.Sqrt(x*x + y*y + z*z);

Console.WriteLine("Hасстояние между двумя точками в 3D пространстве: " + d);
