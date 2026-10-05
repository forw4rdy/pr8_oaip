string answer = "yes";

while (answer == "yes")
{
    Random random = new Random();

    int secretNumber = random.Next(1, 101);

    int attempts = 0;
    bool guessed = false;

    Console.WriteLine("Я загадал число от 1 до 100.");

    while (!guessed)
    {
        Console.WriteLine("Введите число:");

        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("Ошибка. Введите число от 1 до 100.");
            continue;
        }

        attempts++;

        if (number < secretNumber)
        {
            Console.WriteLine("Больше");
        }
        else if (number > secretNumber)
        {
            Console.WriteLine("Меньше");
        }
        else
        {
            Console.WriteLine("Угадал!");
            Console.WriteLine("Количество попыток: " + attempts);

            guessed = true;
        }
    }

    Console.WriteLine("Хотите сыграть еще раз? yes или no");

    answer = Console.ReadLine().ToLower();
}