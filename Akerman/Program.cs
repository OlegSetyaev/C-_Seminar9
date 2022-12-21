int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}


System.Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine(Akkerman(n, m));