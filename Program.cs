// See https://aka.ms/new-console-template for more information
// В переменной string есть секретное сообщение
// во второй есть пароль
// Пользователю дается 3 попытки ввести пароль и увидеть секретное сообщение
// ****
// Добавим команды SetName - установить имя,
// Help - вывести список команд,
// SetPassword - установить пароль,
// Exit - выход из программы,
// WriteName - вывести имя после ввода пароля
string secret = "Вы угадали пароль, возьмите с полки пряник!";
string pass = "123";
string inputUser = String.Empty;
int count = 1;
int max = 3;

Console.WriteLine("Отгадайте пароль с 3 раз");
while (count <= max)
{
    inputUser = ReadString(count.ToString());
    if (inputUser == pass)
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
    string? inputUser = Console.ReadLine();
    return inputUser ?? "null";
}
