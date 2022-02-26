Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

if (number == 1) Console.WriteLine("monday"); else
if (number == 2) Console.WriteLine("thueday"); else
if (number == 3) Console.WriteLine("wendnesday"); else
if (number == 4) Console.WriteLine("thursday"); else
if (number == 5) Console.WriteLine("friday"); else
if (number == 6) Console.WriteLine("saturday"); else
if (number == 7)Console.WriteLine("sunday"); else
{ 
    Console.WriteLine("В неделе 7 дней!");
}
