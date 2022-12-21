// Задача 66 через процедуру

void Sum(int n, int m, int sum)
{
    sum += n;
    if (n > m) Sum(n - 1, m, sum);
    else if (n < m) Sum(n + 1, m, sum);
    else
    {
        System.Console.WriteLine($"{sum}");
    }
}

System.Console.WriteLine("Введите 2 числа через пробел: ");
string[] str = Console.ReadLine().Split(" ");
int n = int.Parse(str[0]);
int m = int.Parse(str[1]);
int sum = 0;
Sum(n, m, sum);