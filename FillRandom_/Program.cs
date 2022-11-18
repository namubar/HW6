int m = 3;
int n = 4;
double[,] array = new double[m, n];
void fillArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = rnd.Next(-100, 100);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
fillArray(array);
