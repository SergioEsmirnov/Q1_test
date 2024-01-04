using System.Globalization;
using System.Xml.XPath;

Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());

string[] array = getArray(elementsCount);//создаем массив с помощью метода
string[] getArray(int size)
{
    string[] array = new string[size];
    for (int i=0; i < size; i++)
        {
        Console.Write($"\nВведите элемент массива с индексовм {i}:\t");
        array[i] = Console.ReadLine();
        }
    return array;
}
printArray(array);


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


string[] newArray = resultArray(array, newArraySize);
string[] resultArray(string[] array, int size)
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


static void printArray (string[] array)
{
    Console.WriteLine($"\n[{String.Join("\t", array)}]");
}

Console.Write("Новый массив: ");
printArray(newArray);