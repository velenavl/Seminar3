// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите положительное число N");
 bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

 if (!isNumberN)
 {
    Console.WriteLine("Не число");
    return;
 }

 PrintCube (GetCube(N));
 int[] GetCube(int n)
 {
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i-1] = (int) Math.Pow (i, 3);
        i++;
    }
    return results;
 }

 void PrintCube(int[] Cube)
 {
    int i = 0;
    int Len = Cube.Length;
    while (i < Len)
    {
        Console.WriteLine(Cube[i]);
        i++;
    }
 }