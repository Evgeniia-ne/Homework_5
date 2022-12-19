// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int SIZE = 10;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[] array = new int[SIZE];


int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
int sum = 0;

for (int j = 1; j < array.Length; j += 2)

{
    sum = sum + array[j];
}

System.Console.WriteLine('[' + string.Join(", ", array) + ']');
System.Console.WriteLine("Сумма элементов с нечетным индексом: " + sum);
