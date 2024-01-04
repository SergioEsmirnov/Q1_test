Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
string[] array = new string[elementsCount];
for (int i=0; i < elementsCount; i++)
{
    Console.Write($"\nВведите элемент массива с индексовм {i}:\t");
    array[i] = Console.ReadLine();
}
//Console.WriteLine($"\nМассив: [{String.Join("\t", array)}]");

printArray(array);
static void printArray (string[] array)
{
    Console.WriteLine($"\nМассив: [{String.Join("\t", array)}]");
}