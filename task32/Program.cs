// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();
int[] array = new int[7]; // можно менять количество элементов
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('['+string.Join(", ", array) + ']');
for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    // if(array[i] != 0)
    // {
    //     array[i] = array[i] * -1;
    // }
    // else
    // {
    //     array[i] = array[i];
    // }
}
Console.WriteLine('['+string.Join(", ", array) + ']');