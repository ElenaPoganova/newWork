Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()), count = a;
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < b; i++)
{
    count = count * a;
}
Console.WriteLine(count);
