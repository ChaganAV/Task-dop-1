﻿string inputUser = String.Empty;
int countTrial = 1;
int maxTrial = 3;
string userName = String.Empty;
string userPassword = String.Empty;

Console.WriteLine("Введите help для вывода списка доступных команд");
inputUser = ReadString(">> ");
DetectionCommand(inputUser);


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