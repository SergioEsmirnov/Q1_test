using System.Globalization;
using System.Xml.XPath;

Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
string[] array = new string[elementsCount];
for (int i=0; i < elementsCount; i++)
{
    Console.Write($"\nВведите элемент массива с индексовм {i}:\t");
    array[i] = Console.ReadLine();
}
//Console.WriteLine($"\nМассив: [{String.Join("\t", array)}]");

int newArraySize = countNewElements(array);

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


string[] newArray = new string[newArraySize];
int j = 0;
for (int i=0; i < elementsCount; i++)
{
        if(array[i].Length<=3)
        {
            newArray[j] = array[i];
            j++;
        }    
}


printArray(array);
static void printArray (string[] array)
{
    Console.WriteLine($"\n[{String.Join("\t", array)}]");
}

Console.Write("Новый массив: ");
printArray(newArray);