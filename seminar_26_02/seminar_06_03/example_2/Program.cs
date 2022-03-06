// Задача 3: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.


int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int x1 = Prompt("Координата х первой точки: ");
int y1 = Prompt("Координата у первой точки: ");
int x2 = Prompt("Координата х второй точки: ");
int y2 = Prompt("Координата у второй точки: ");

int x = x1 - x2;
int y = y1 - y2;

double d = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));

Console.WriteLine(d);