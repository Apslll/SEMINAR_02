// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (a > index) index = index * 10;
if (index <= 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine((a % (index / 100)) / (index / 1000));