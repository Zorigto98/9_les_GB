int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m-1, 1);
    // if (m > 0 && n > 0) 
    return Akkerman(m-1, Akkerman(m , n -1));
}

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана: {M} {N} = {Akkerman(M, N)}");