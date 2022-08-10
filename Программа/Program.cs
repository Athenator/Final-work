Console.Write("Введите длинну массива: ");
int l = int.Parse(Console.ReadLine()!);

string [] array1;

string [] array2;

array1 = new string[l];
array2 = new string[l];

for (int i = 0; i < l; i++)
{
  Console.Write($"Введите {i+1} элемент массива: ");
  array1 [i] = Console.ReadLine()!;
  array2 [i] = array1 [i];
  
}

Console.Write("Вывод массива: ");
Console.Write(" [");
for (int i = 0; i < l; i++)
{
  Console.Write(" ");
  Console.Write(array1[i]);
  Console.Write(" ");

}
Console.Write("] -> ");
Console.Write(" [");
for (int i = 0; i < l; i++)
{
    if(array2[i].Length <= 3)
    {
        Console.Write(" ");
        Console.Write(array2[i]);
        Console.Write(" ");
    }
}
Console.Write("] ");


