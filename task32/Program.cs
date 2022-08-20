// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();
int[] array = new int[4]; // можно менять количество элементов
int sumPositive = 0;
int sumNegative = 0;
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('['+string.Join(", ", array) + ']');
for(int i = 0; i < array.Length; i++)
{
    if(array[i]> 0)
    {
        sumPositive+= array[i];
    }
    else
    {
        sumNegative+= array[i];
    }
}
Console.WriteLine($"сумма положительных чисел равна {sumPositive} сумма отрицательных равна {sumNegative} ");