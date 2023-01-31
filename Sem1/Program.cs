void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); 
}

int summ = 0;
void ReleaseArray(int[] array)
 {
    for (int i = 1; i < array.Length; i+=2)
    summ +=array[i];
    Console.Write($"{summ}");
 }

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);

