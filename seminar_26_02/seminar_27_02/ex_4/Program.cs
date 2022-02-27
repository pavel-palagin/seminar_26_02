// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите число a: ");
string strValue1 = Console.ReadLine();
int a = int.Parse(strValue1);


int result1 = a % 7;
int result2 = a % 23;

if (result1 == 0 && result2 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
