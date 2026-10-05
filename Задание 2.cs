Console.WriteLine("Введите количество строк:");

int n = int.Parse(Console.ReadLine());

if (n <= 0 || n % 2 == 0)
{
    Console.WriteLine("Ошибка. Нужно ввести положительное нечетное число.");
}
else
{
    int middle = n / 2;

    for (int i = 0; i < n; i++)
    {
        int spaces;
        int stars;

        if (i <= middle)
        {
            spaces = middle - i;
            stars = 2 * i + 1;
        }
        else
        {
            spaces = i - middle;
            stars = 2 * (n - i) - 1;
        }

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < stars; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}