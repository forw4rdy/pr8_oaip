Console.WriteLine("Введите пароль:");

string password = Console.ReadLine();

bool hasDigit = false;
bool hasUpper = false;
bool hasSpecial = false;

for (int i = 0; i < password.Length; i++)
{
    char symbol = password[i];

    if (char.IsDigit(symbol))
    {
        hasDigit = true;
    }

    if (char.IsUpper(symbol))
    {
        hasUpper = true;
    }

    if (!char.IsLetterOrDigit(symbol) && symbol != ' ')
    {
        hasSpecial = true;
    }
}

if (password.Length >= 8 &&
    hasDigit &&
    hasUpper &&
    hasSpecial)
{
    Console.WriteLine("Пароль надежный.");
}
else
{
    Console.WriteLine("Пароль ненадежный.");

    if (password.Length < 8)
    {
        Console.WriteLine("Длина должна быть не менее 8 символов.");
    }

    if (!hasDigit)
    {
        Console.WriteLine("Должна быть хотя бы одна цифра.");
    }

    if (!hasUpper)
    {
        Console.WriteLine("Должна быть хотя бы одна заглавная буква.");
    }

    if (!hasSpecial)
    {
        Console.WriteLine("Должен быть хотя бы один специальный символ.");
    }
}