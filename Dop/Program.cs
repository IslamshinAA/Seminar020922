int[] f = { 5123726, 2343, 356, 912, 71, 0, 649, 0 };
void Mass(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    int max2 = 0;
    int max = 0;
    while (index < length)
    {
        if (numbers[index] == 0)
        {
            break;
        }
        else
        {
            for (int i = 0; i < length; i++);
            {
                if (numbers[index] > max)
                {
                    max2 = max;
                    max = numbers[index];
                }
                else if (numbers[index] > max2) max2 = numbers[index];
            }
        }
        index++;
    }
    Console.WriteLine(max2);
}
void PrintMass(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}
PrintMass(f);
Console.WriteLine("_____________");
Mass(f);
