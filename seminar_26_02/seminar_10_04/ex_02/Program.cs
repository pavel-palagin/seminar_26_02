// Задача 2: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

int n = 1;

void Words(string alphabet, char [] letter, int length = 0)
{
    if (length == letter.Length)
    {
        Console.WriteLine($"{n++}: {new string(letter)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        letter[length] = alphabet[i];
        Words (alphabet, letter, length + 1);
    }
}

Words("абвг", new char[2]);