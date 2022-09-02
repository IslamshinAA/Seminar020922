//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int Number()
{
    Console.WriteLine("Input number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
void Magic()
{
    int a = Number();
    if (a >= 100)
        Console.WriteLine(Convert.ToString (a)[2]);
else
Console.WriteLine("The third digit is not");

}
Magic();