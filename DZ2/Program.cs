// Задача 66 через функцию

int Summ(int n, int m)
{
    int sum = 0;
    if (n > m + 1) sum = n + Summ(n - 1, m);
    else if (n < m - 1) sum = n + Summ(n + 1, m);
    else sum = n + m;
    return sum;
}

System.Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine(Summ(n, m));
