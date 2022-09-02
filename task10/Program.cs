//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int Number()
{
int n = new Random().Next(100,1000);
return n;
}
void GoNumber()
{
 int n = Number();
 int a = n / 10;
 int b = a % 10;
 Console.WriteLine(n);
 Console.WriteLine(b);

}
GoNumber();




    