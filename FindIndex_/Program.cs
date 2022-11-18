int[,] array = new int[,]
            {
                { 10, 21, 31, 41 },
                { 22, 11, 42, 52 },
                { 13, 23, 33, 43 }
            };
Console.Write("Введите искомое число: ");
int value = int.Parse(Console.ReadLine()!);
Console.WriteLine("**************************");
int str = 0;
int row = 0;
bool f = false;
void findIndex(int[,] array, int value)
{

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (value == array[i, j])
        {
            str = i; row = j; f = true;
        }
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if (f)
{
    Console.WriteLine("**************************");
    Console.WriteLine($"Индекс искомого числа: {str},{row}");
}
else
{
    Console.WriteLine("**************************");
    Console.WriteLine("Число не найдено!");
}
 }
 findIndex(array, value);









