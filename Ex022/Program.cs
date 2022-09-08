// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите положительное число N");
 bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

 if (!isNumberN)
 {
    Console.WriteLine("Не число");
    return;
 }

 PrintSqares (GetSqares(N));
 int[] GetSqares(int n)
 {
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i-1] = (int) Math.Pow (i, 2);
        i++;
    }
    return results;
 }

 void PrintSqares(int[] Sqares)
 {
    int i = 0;
    int Len = Sqares.Length;
    while (i < Len)
    {
        Console.WriteLine(Sqares[i]);
        i++;
    }
 }