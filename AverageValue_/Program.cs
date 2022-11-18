Random random = new Random();
int[,] array = new int[4, 4];
void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void countRow(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        double result = sum / arr.GetLength(0);
        result = Math.Round(result, 2);
        Console.WriteLine($"Среднее арифметическое {j} столбца: {result} \t");
    }
}
fillArray(array);
Console.WriteLine("**************************************");
countRow(array);