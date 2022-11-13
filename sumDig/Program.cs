Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (M > N)
{
    int temp = M;
    M = N;
    N = temp;
}
for (int i = M; i <= N; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма элементов от {M} до {N} = {sum}");