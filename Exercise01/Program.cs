/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
}

//Получение чисел от пользователя.
Console.WriteLine("Программа считает возведение в степень B по основанию A.");
Console.Write("Введите основание A = ");
int.TryParse(Console.ReadLine(), out int A);
while (A < 0)
{
    Console.WriteLine("Число должно быть 0 или больше. Повторите ввод.");
    Console.Write("Введите показатель степени A = ");
    int.TryParse(Console.ReadLine(), out A);
}

Console.Write("Введите степень B = ");
int.TryParse(Console.ReadLine(), out int B);
while (B < 0)
{
    Console.WriteLine("Число должно быть 0 или больше. Повторите ввод.");
    Console.Write("Введите показатель степени B = ");
    int.TryParse(Console.ReadLine(), out B);
}