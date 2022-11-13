Console.WriteLine("Введите первое число");
int First = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество элементов, которых нужно вывести");
int N = Convert.ToInt32(Console.ReadLine());

if (First > Second)
{
    int temp = First;
    First = Second;
    Second = temp;
}
Console.Write($"{First} {Second} ");
for (int i = 0; i < N; i++)
{
    int Next = First + Second;
    First = Second;
    Second = Next;
    Console.Write($"{Next} ");
}