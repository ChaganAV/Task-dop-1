string inputUser = String.Empty;

string userName = String.Empty;
string userPassword = String.Empty;
int countTestPass = 3;


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
            SetName();
            break;
        case "setPassword":
            SetPassword();
            break;
        case "writeName":
            WriteName();
            break;
        case "exit":
            break;
        default:
            Console.WriteLine($"Команды {strName} нет!");
            break;
    }
}

void SelectListCommand()
{
    Console.WriteLine("help - вывести список команд");
    Console.WriteLine("setName - установить имя");
    Console.WriteLine("setPassword - установить пароль");
    Console.WriteLine("writeName - вывести имя после ввода пароля");
    Console.WriteLine("exit - выход из программы");
}
void SetName()
{
    userName = ReadString("Введите имя: ");
    if (userName is null || userName.Length < 1)
    {
        userName = ReadString("Вы не ввели имя, попробуйте еще раз: ");
    }
}
void SetPassword()
{
    userPassword = ReadString("Введите пароль: ");
    if (userPassword is null || userPassword.Length<1)
    {
        userPassword = ReadString("Вы не ввели пароль, попробуйте еще раз: ");
    }
}
void WriteName()
{
    if (userName is null || userName.Length < 1)
    {
        Console.WriteLine("Вы не ввели имя!");
        return;
    }
    if (userPassword is null || userPassword.Length < 1)
    {
        Console.WriteLine("Вы не ввели пароль!");
        return;
    }
    string password = ReadString("Введите пароль:");
    for(int i = 0; i < countTestPass; i++)
    {
        if (password == userPassword)
        {
            Console.WriteLine($"Ваше имя: {userName}");
            break;
        }
        else
            password = ReadString("Пароль не верный, попробуйте еще раз: ");
        if (password != userPassword && i == countTestPass-1)
        {
            Console.WriteLine("К сожалению пароль не верный!");
        }
    }
}
