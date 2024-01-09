//int n = 10;
int[] array = { 12, 51, 41, 37, 18, 35, 11, 32, 82, 51 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
