Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {M} до {N}:");
if (M > N)
{
    int temp = M;
    M = N;
    N = temp;
}
for (int i = M; i <= N; i++)
{
    Console.WriteLine(i);
}