int[] f = { 5, 2, 356, 9, 71, 0, 649, 0 };
void Mass(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    int max2 = 0;
    int max = numbers[0];
    while (index < length)
    {
        if (numbers[index] == 0)
        {
            break;
        }
        else 
        {
            for (int i = 0; i < numbers[index]; i++) ;
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
