// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.Clear();
// int[] array = new int[12]; // можно менять количество элементов
// int sumPositive = 0;
// int sumNegative = 0;
// Random rand = new Random();// int a = new Random()Next(-9, 10) - то же самое, но Random rand  нужен, чтобы можно было заполнять несколько раз
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }
// Console.WriteLine('['+string.Join(", ", array) + ']');
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i]> 0)
//     {
//         sumPositive+= array[i]; / эквивалентно 
//     }
//     else
//     {
//         sumNegative+= array[i];
//     }
// }
// Console.WriteLine($"сумма положительных чисел равна {sumPositive} сумма отрицательных равна {sumNegative} ");

// ФУНКЦИИ
//1 функция, принимает значения размер, левая граница, правая граница
int[] FillArray(int size, int leftRange, int rightRange)
{
    //создаем массив с размером size, левая граница, правая граница
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)// заполнение массива
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
//     получаем переменные в котрые после должны будем записать суммы + и - чисел
void sumPositiveAndsumNegative(int[] arr, out int sumPositive, out int sumNegative) //  так как void ничего не возвращает, используем out int, то есть в самом коде пишем, в какую переменную будут возвращаться эти значения
{
        sumPositive = 0;
        sumNegative = 0;
        for(int i = 0; i < arr.Length; i++)
    {
            if(arr[i]> 0)
        {
        sumPositive+= arr[i];
        }
            else
        {
            sumNegative+= arr[i];
        }
    }
}
int[] array = FillArray(5, -9, 9);
sumPositiveAndsumNegative(array, out int sumP, out int sumN);
Console.WriteLine('['+string.Join(", ", array) + ']');
Console.WriteLine($"сумма положительных чисел равна {sumP} сумма отрицательных равна {sumN} ");
