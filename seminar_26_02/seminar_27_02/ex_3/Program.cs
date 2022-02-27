// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.

Console.WriteLine("Введите число a: ");
string strValue1 = Console.ReadLine();
int a = int.Parse(strValue1);

Console.WriteLine("Введите число b: ");
string strValue2 = Console.ReadLine();
int b = int.Parse(strValue2);

int result = a % b;

if (result == 0) Console.WriteLine("кратно");
else Console.WriteLine("не кратно "+ result);

