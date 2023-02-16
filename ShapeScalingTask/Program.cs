//Написать программу масштабирования фигуры

Console.Write("Сколько углов у фигуры: ");
int corners = int.Parse(Console.ReadLine() ?? "");
int[] mass = new int[corners * 2];
Console.WriteLine();
for (int i = 0; i < corners * 2; i++)
{
    Console.Write("Введите координату: ");
    mass[i] = int.Parse(Console.ReadLine() ?? "");
}
Console.WriteLine("Изначальные координаты фигуры: ");
for (int i = 0; i < corners * 2; i++)
    Console.Write("'{0}'", string.Join(" ", mass[i]));
Console.WriteLine();
Console.WriteLine("Во сколько раз масштабируем фигуру: ");
int plusSize1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Итоговые координаты фигуры: ");
for (int i = 0; i < corners * 2; i++)
    Console.Write("[{0}]", string.Join(" ", (mass[i] * plusSize1)));