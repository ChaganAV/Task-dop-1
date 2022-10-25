// See https://aka.ms/new-console-template for more information
// В переменной string есть секретное сообщение
// во второй есть пароль
// Пользователю дается 3 попытки ввести пароль и увидеть секретное сообщение
// ****
// Добавим команды
// SetName - установить имя,
// Help - вывести список команд,
// SetPassword - установить пароль,
// Exit - выход из программы,
// WriteName - вывести имя после ввода пароля
// ****
string secret = "Вы угадали пароль, возьмите с полки пряник!";
string pass = "123";
string inputUser = String.Empty;
int count = 1;
int max = 3;

Console.WriteLine("Введите help для вывода списка доступных команд");
inputUser = ReadString(count.ToString());
DetectionCommand(inputUser);

void DetectionCommand(string strName)
{
    switch (strName)
    {
        case "help": 
            Console.WriteLine("help - вывести список команд");
            Console.WriteLine("setName - установить имя");
            Console.WriteLine("setPassword - установить пароль");
            Console.WriteLine("exit - выход из программы");
            Console.WriteLine("writeName - вывести имя после ввода пароля");
            break;
        case "setName":
            break;
        case "setPassword":
            break;
        case "exit":
            break;
        case "writeName":
            break;
        default:
            Console.WriteLine($"Команды {} нет!");
            break;
    }
}

string ReadString(string message)
{
    Console.WriteLine($"Попытка {message}");
    string? inputUser = Console.ReadLine();
    return inputUser ?? "null";
}
