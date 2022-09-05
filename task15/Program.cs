// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет
int Week()
{
    Console.WriteLine("Ввведите цифру с 1-7 соотвествующую дню недели: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
void Day()
{
    int n = Week();
    if (n >= 1 && n <= 7)
    {   if (n < 6)
        Console.WriteLine("Будний день, не время отдыхать");
        else 
        Console.WriteLine("Выходной, кайфуй");
    }
    else 
    Console.WriteLine("Не верное число!");
}
Day();
