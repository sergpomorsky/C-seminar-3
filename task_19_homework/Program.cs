// Задача 19: Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine("Введите число");
string numberText = Console.ReadLine();
int[]array = new int [5];
if(numberText[0] == numberText[4] && numberText[1] == numberText[3])
Console.WriteLine("Ваше число - палиндром");
else
Console.WriteLine("Ваше число - не палиндром");
