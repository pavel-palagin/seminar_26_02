// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string n = Console.ReadLine();
int len = n.Length;
int i = 0;




while (i < len/2)
{
    if (n[i] != n[len-1-i]) Console.WriteLine("Не полиндром");
    break;
    i++;
    else Console.WriteLine("Полиндром");
    
}











// int n = pront("Введите число: ");
// int pront(string strValue)
// {
//     Console.WriteLine(strValue);
//     string Value = Console.ReadLine();
//     int a = int.Parse(Value);
//     return a;
// }

// int n1 = n / 10000;





// if (n < 100) Console.WriteLine("Третьей цифры нет");
// if (n > 99 && n < 1000) Console.WriteLine("Третья цифра введенного числа: " + n%10);
// if (n > 999 && n < 10000) Console.WriteLine("Третья цифра введенного числа: " + n/10%10);
// if (n > 9999 && n < 100000) Console.WriteLine("Третья цифра введенного числа: " + n/100%10);
// if (n > 99999 && n < 1000000) Console.WriteLine("Третья цифра введенного числа: " + n/1000%10);
// if (n > 999999 && n < 10000000) Console.WriteLine("Третья цифра введенного числа: " + n/100000%10);
// if (n > 9999999 && n < 100000000) Console.WriteLine("Третья цифра введенного числа: " + n/100000%10); 
