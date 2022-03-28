// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Первое решение задачи");

// int Promt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine();
//     int Value = int.Parse(strValue);
//     return Value;
// }

// int N = Promt("Введите пятизначное число: ");

// if (N < 10000 | N > 99999) Console.WriteLine("Не соответствует условиям задачи");
// else 
// {
//     int a = N / 10000;
//     int b = N / 1000 % 10;
//     int c = N / 100 % 10;
//     int d = N / 10 % 10;
//     int e = N % 10;

//     Console.WriteLine($"{a}{b}{c}{d}{e}");

//     if (a == e & b == d) Console.WriteLine("Полиндром");
//     else Console.WriteLine("Не полиндром");

// }


// Console.WriteLine("Второе решение задачи");

// Console.Write("Введите пятизначное число: ");
// string n = Console.ReadLine();
// int len = n.Length;


// if (len == 5) 
// {
//     if (n[0] == n[4] & n[1] == n[3]) Console.WriteLine("Полиндром");
//     else Console.WriteLine("Не полиндром");
// }
// else Console.WriteLine("Не соответствует условиям задачи");   
    

// Console.WriteLine("Третье решение задачи");

Console.Write("Введите число: ");
string n = Console.ReadLine();
int size = n.Length;
int i = 0;

while (i < size/2)
{
    if (n[i] != n[size - 1 - i])
    {
        Console.WriteLine("Не полиндром");
        break;
    }
    i++;
    if (i == size/2) Console.WriteLine("Полиндром");
}

// for (int i = 0; i < size/2; i++)
//     if (n[i] != n[size-1-i]) Console.WriteLine("Не полиндром");
//     else Console.WriteLine("Полиндром");

// Console.WriteLine("Четвертое решение задачи");

// int Promt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine();
//     int Value = int.Parse(strValue);
//     return Value;
// }

// int N = Promt("Введите число: ");

// int n = N % 10;

// Console.WriteLine(n);


/*
string str = Console.ReadLine();
char[] a = str.ToCharArray;

for(i =0; i<a.Length-1;i++){
for(j=a.Length-1; j>0;j--){
if(a[i]==a[j]){
Int ans = 1;
} else {
ans = 0;
}
If(ans == 1){
Console.WriteLine("True");
}
else{
Console.WriteLine("False");
*/