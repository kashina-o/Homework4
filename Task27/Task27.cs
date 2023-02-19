// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int Input(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void SumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    Console.WriteLine("Cумма цифр в числе равна: " + sum);
}

SumOfDigits(Input("Введите число:"));

