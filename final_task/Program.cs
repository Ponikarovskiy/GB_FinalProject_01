// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
// Метод для ввода массива строк от пользователя
string[] UserInputArray(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите строку №{i}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

// Метод для создания нового массива из 3 и меньше символов
string[] ThreeCharArray(string[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
            count++;
    }
    string[] finishArray = new string[count];
    count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            finishArray[count] = userArray[i];
            count++;
        }
    }    
    return finishArray;
}

// Метод печати массива строк в консоль
void PrintArray(string[] printArr)
{
    System.Console.Write("[");
    for (int i = 0; i < printArr.Length; i++)
    {
        if (i == printArr.Length - 1)
            System.Console.Write($"\"{printArr[i]}\"");
        else
            System.Console.Write($"\"{printArr[i]}\", ");
    }
    System.Console.WriteLine("]");
}

System.Console.WriteLine("Запрос от пользователя массив строк.\n"
                + "Вывод всех строк состоящих из 3 и меньше символов в новый массив.");
System.Console.WriteLine("Сколько будет строк в исходном массиве?");
System.Console.Write(">>: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
    System.Console.WriteLine("Число меньше 1! Невозможно создать массив. Введите заново: ");
    int.TryParse(Console.ReadLine(), out num);
}
string[] userArray = UserInputArray(num);
string[] threeCharArray = ThreeCharArray(userArray);
System.Console.WriteLine("Изначальный массив:");
PrintArray(userArray);
System.Console.WriteLine("Полученный массив:");
PrintArray(threeCharArray);