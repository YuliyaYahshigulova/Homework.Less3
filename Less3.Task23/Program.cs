Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Pow(int n)
{
    int power = 3;
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}^{power} = {Math.Pow(i, power)}");
    }
}
Pow(n);
















//int value = 2;
//for (int power = 0; power <= 32; power++)
//   Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power)} ");

