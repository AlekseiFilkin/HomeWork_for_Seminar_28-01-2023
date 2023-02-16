//Написать программу копирования массива

int[] array1 = new int[10];
int[] array2 = new int[array1.Length];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 100);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}  ");
}
void CopyArray(int[] array, int[] copyArray)
{
    for (int i = 0; i < array.Length; i++) copyArray[i] = array[i];
}
FillArray(array1);
Console.WriteLine("Массив:");
PrintArray(array1);
Console.WriteLine();
CopyArray(array1, array2);
Console.WriteLine("Скопированный массив:");
PrintArray(array2);