// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна трём символам.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры результатов работы программы

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] givenArray = new string[10] { "Never", "put", "off", "till", "tomorrow", "what", "you", "can", "do", "today" };
int size = ArrayLength(givenArray);
PrintArray(givenArray);
string[] newArray = NewArray(givenArray, size);
Console.WriteLine();
PrintArray(newArray);

int ArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArray(string[] givenArray, int count)
{
    string[] result = new string[count];
    {
        for (int i = 0; i < givenArray.Length; i++)
        {
            if (givenArray[i].Length <= 3)
            {
                result[result.Length - count] = givenArray[i];
                count--;
            }
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

