int[] numbers = { 6, 2, 356, 9, 7, 91, 64, 0 };
int length = numbers.Length;
int index = 0;
int position = 0;
int max2 = 0;
int max = numbers[0];
while (index < length)
{
    if (numbers[index] == 0)
    {
        position = numbers[index];
        break;
    }
    else if (numbers[index] != 0)
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
PrintMass(numbers);
Console.WriteLine("_____________");
Console.WriteLine(max2);


