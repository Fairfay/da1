Console.WriteLine("Hello, World!");
int a = 1;
double per = ((Math.Pow(-1, a)) / (a * (2 * a + 1)));
double summa = 0;
Console.WriteLine("Введите E=");
double E= double.Parse(Console.ReadLine());
while (Math.Abs(per) >= E)
{
    summa += per;
    a++;
    per = ((Math.Pow(-1, a)) / (a * (2 * a + 1)));
}
Console.WriteLine("Сумма=" + summa);
Console.WriteLine("Последнее слагаемое=" + per);
Console.WriteLine("Последнее слагаемое по модулю=" + Math.Abs(per));
Console.WriteLine("Кол-во слагаемых-=" + a);