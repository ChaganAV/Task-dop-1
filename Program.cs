string inputUser = String.Empty;

string userName = String.Empty;
string userPassword = String.Empty;


Console.WriteLine("Введите help для вывода списка доступных команд");
while(inputUser != "exit")
{
    inputUser = ReadString(">> ");
    DetectionCommand(inputUser);
}


// Функции
string ReadString(string message)
{
    Console.Write($"{message}");
    string? inputUser = Console.ReadLine();
    return inputUser ?? "null";
}

void DetectionCommand(string strName)
{
    switch (strName)
    {
        case "help": 
            SelectListCommand();
            break;
        case "setName":
            SetName(strName);
            break;
        case "setPassword":
            SetPassword(strName);
            break;
        case "writeName":
            WriteName();
            break;
        case "exit":
            return;
        default:
            Console.WriteLine($"Команды {strName} нет!");
            break;
    }
}

void SelectListCommand()
{
    Console.WriteLine("help (-h) - вывести список команд");
    Console.WriteLine("setName (-sn) - установить имя");
    Console.WriteLine("setPassword (-sp) - установить пароль");
    Console.WriteLine("writeName (-wn) - вывести имя после ввода пароля");
    Console.WriteLine("exit (q) - выход из программы");
}
void SetName(string name)
{
    userName = ReadString("Введите имя: ");
}
void SetPassword(string password)
{
    userPassword = ReadString("Введите пароль: ");
}
void WriteName()
{
    string password = ReadString("Введите пароль:");
    for(int i = 0; i < 3; i++)
    {
        if (password == userPassword)
        {
            Console.WriteLine($"Ваше имя: {userName}");
            break;
        }
        else
            password = ReadString("Пароль не верный, попробуйте еще раз: ");
        if (password != userPassword && i == 2)
        {
            Console.WriteLine("К сожалению пароль не верный!");
            return;
        }
    }
}
