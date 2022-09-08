
string[] stringArray = new string[4];
int size = stringArray.Length;
string[] stringArraySort = new string[size];

Console.WriteLine("Введите любые 4 слова (набор букв, символов) через нажатие Enter:");
for (int i = 0; i < stringArray.Length; i++)
{
    stringArray[i] = Console.ReadLine();
}

Console.Write("Вы ввели следующий массив строк: ");
PrintArray(stringArray);
SortArray(stringArray, stringArraySort);
Console.Write("Массив строк, в которых три или менее символов, после сортировки введенного массива: ");
if(size == 0) Console.WriteLine("[]");
else PrintArray(stringArraySort);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}

void SortArray(string[] Array, string[] ArraySort)
{
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {        
        if (Array[i].Length <= 3) 
        {
            ArraySort[j] = Array[i]; 
            j++;        
        }      
    }
    size = j;
}
