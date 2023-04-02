/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int Prompt(string message)//--------------------------число с консоли
{
    Console.Write(message);
    string v = Console.ReadLine();
    int result = Convert.ToInt32(v);
    return result;
}

int[] InputArray (int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

void PrintArray (int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"digit {i + 1} = {array[i]}");
    }
}

int CountPositive (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt ("Введите количество чисел ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество элементов > 0 = {CountPositive(array)}");

