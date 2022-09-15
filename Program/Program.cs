// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
string[] CreateArray(int size)
{
string [] newArray = new string[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}
void ModArray(string[] array)
{
    string [] modArray = new string[array.Length];
    int j=0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length<=3) 
            {
                modArray[j]=array[i];
                j++;
            }
    for(int i = 0; i < j; i++)
        {
            if (i<j-1)
            Console.Write(modArray[i] + ", ");
            else Console.Write(modArray[i]);
        }
}
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray (n);
Console.Write("Массив элементов, длина которых меньше, либо равна 3 символам: ");
ModArray(myArray);


