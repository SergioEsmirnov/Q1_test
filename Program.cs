using System.Globalization;
using System.Xml.XPath;

Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());//запрашиваем количество элементов в создаваемом массиве

string[] array = getArray(elementsCount);//создаем массив с помощью метода
string[] getArray(int size) //создаем метод для генерации массива из вводимых значений
{
    string[] array = new string[size];
    for (int i=0; i < size; i++)
        {
        Console.Write($"\nВведите элемент массива с индексовм {i}:\t");
        array[i] = Console.ReadLine();
        }
    return array;
}
Console.Write("\nИсходный массив: ");
printArray(array); //выводим массив из введенных элементов


int newArraySize = countNewElements(array); // считаем в массиве 
// количество элементов длиной не более 3 символов с помощью метода

int countNewElements(string[] array)
{
    int elements = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            elements++;
        }
    }
    return elements;
}


string[] newArray = resultArray(array, newArraySize);//создаем новый массив с элементами длиной не более 3 символов
string[] resultArray(string[] array, int size) // создаем метод которые генерирует из
// исходного массива новый массив с элементами длиной не более 3 символов
{
        string[] newArray = new string[size];
    int j = 0;
    for (int i=0; i < array.Length; i++)
        {
            if(array[i].Length<=3)
                {
                    newArray[j] = array[i];
                    j++;
                }    
        }
    return newArray;
}


static void printArray (string[] array) // создаем метод вывода массива
{
    Console.WriteLine($"\n[{String.Join("\t", array)}]");
}

Console.Write("\nНовый массив: ");
printArray(newArray); //выводим массив с элементами длиной не более 3 символов