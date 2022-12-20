// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int SIZE = 10;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

double[] array = new double[SIZE];


double[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() + rand.Next(leftRange, rightRange + 1), 2);
    }
    return arr;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

System.Console.WriteLine('[' + string.Join("; ", array) + ']');
System.Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");



