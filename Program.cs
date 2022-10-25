string inputUser = String.Empty;
int countTrial = 1;
int maxTrial = 3;

Console.WriteLine("Введите help для вывода списка доступных команд");
inputUser = ReadString(countTrial.ToString());
DetectionCommand(inputUser);


// Функции
string ReadString(string message)
{
    Console.WriteLine($"{message}");
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
            break;
        case "setPassword":
            break;
        case "exit":
            break;
        case "writeName":
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
void SetName(string name)
{

}
void SetPassword(string password)
{

}
void WriteName()
{

}