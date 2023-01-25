/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Получение массива от пользователя
int[] GenerateArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        int.TryParse(Console.ReadLine(), out array[i]);
    }
    return array;
}

//Печать массива на экран
void PrintArray(int[] arrayPrint)
{
    Console.Write("Полученный массив: ");
    Console.Write("[");
    for (int index = 0; index < arrayPrint.Length; index++)
    {
        if (index == (arrayPrint.Length - 1))
            Console.WriteLine($"{arrayPrint[index]}]");
        else
            Console.Write($"{arrayPrint[index]}, ");
    }
}

Console.WriteLine("Программа запрашивает создание массива с заданным количеством элементов");
Console.Write("Введите количество элементов в массиве: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
    Console.WriteLine("Введено значение меньше 1, массив не может быть создан.\n"
                    + "Повторите ввод количества элементов массива:");
    int.TryParse(Console.ReadLine(), out num);
}

PrintArray(GenerateArray(num));
Author();