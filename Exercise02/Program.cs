/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
}

int Absolute (int num)
{
    if (num < 0)
    {
        num *= (-1);
        return num;
    }
    else
        return num;
}

int SumOfDigits(int digits)
{
    int sum = 0;
    int temp = 0;
    while (digits > 0)
    {
        temp = digits % 10;
        sum += temp;
        digits /= 10;
    }
    return sum;
}

Console.WriteLine("Программа считает сумму цифр в введённом числе.");
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine($"Сумма цифр в числе {number} = {SumOfDigits(Absolute(number))}");

Author();