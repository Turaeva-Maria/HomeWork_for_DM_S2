// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write ("Ведите номер, обозначающий день недели (от 1 до 7): ");
int n=Convert.ToInt32(Console.ReadLine());

while (n<1 || n>7 )
{
    Console.Write("Вы издеваетесь? Введите значение от 1 до 7: ");
    n=Convert.ToInt32(Console.ReadLine());
}
if (n<=5)
{
    Console.WriteLine("Будний день");
}
else 
    Console.WriteLine("Выходной день");

  

