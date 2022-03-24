// Напишите программу, которая принимает на вход 
//число и выдает количество цифр в числе

/*
string number = Promt("Введите число: ");
int size = number.Length;
Console.WriteLine($"Количество цифр в числе {number} равно {size}");

string Promt(string message)
{
    Console.Write(message);
    string Value = Console.ReadLine();
    return Value;
}
*/

/*
Random rmd = new Random();
int digit = rmd.Next();
string newDigit = digit.ToString();
int len = newDigit.Lenght;
Console.WriteLine($"Количество цифр в числе {digit} равно {len}");

string Promt(string message)
{
    Console.Write(message);
    string Value = Console.ReadLine();
    return Value;
}
*/
/*
string number = Randomize();
int lenT = number.Length;
Console.WriteLine($"Количество цифр в числе {number} равно {lenT}");

string Randomize()
{
Random rnd = new Random();
int digit = rnd.Next();
string newDigit = digit.ToString();
return newDigit;
}

string Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    return strValue;
}
*/

// string number = Promt("Введите число: ");
// int len = number.Length;
// int temp = int.Parse(number);
// if (temp <= 0 || temp > 0) Console.WriteLine($"Количество цифр в числе {number} равно {len}");
// else Console.WriteLine("Введите число");

int i = 1;

while (temp/10 != 0)
{
    temp = temp / 10;
    i++;
}


