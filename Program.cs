// See https://aka.ms/new-console-template for more information
// В переменной string есть секретное сообщение
// во второй есть пароль
// Пользователю дается 3 попытки ввести пароль и увидеть секретное сообщение
string secret = "Вы угадали пароль, возьмите с полки пряник!";
string pass = "123";
string test = String.Empty;
int count = 1;
int max = 3;

Console.WriteLine("Отгадайте пароль с 3 раз");
while (count <= max)
{
    test = ReadString(count.ToString());
    if (test == pass)
    {
        Console.WriteLine(secret);
        break;
    }
    else
    {
        Console.WriteLine($"К сожалению, не получилось, попробуйте еще раз, осталось {max-count} попыток");
    }
    count++;
}


string ReadString(string message)
{
    Console.WriteLine($"Попытка {message}");
    string? input = Console.ReadLine();
    return input ?? "null";
}
