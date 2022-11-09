Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int a, b, d, f;
if (10000 <= n && n < 100000)
{
    a = n / 10000;
    b = (n / 1000) % 10;
    d = (n / 10) % 10;
    f = n % 10;
    if (a == f && b == d)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
}
else
{
    Console.WriteLine("Введено неверное число!");
}