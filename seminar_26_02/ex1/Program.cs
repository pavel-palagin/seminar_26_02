Console.WriteLine("Введите число a: ");
string strValue1 = Console.ReadLine();
int a = int.Parse(strValue1);

Console.WriteLine("Введите число b: ");
string strValue2 = Console.ReadLine();
int b = int.Parse(strValue2);

int квадрат = a * a; 

if (квадрат == b)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
