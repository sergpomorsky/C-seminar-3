// *Задача 23: * Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int B = 1;
int[]array = new int [A];
while(B <= A)
{
array[B-1] = B*B*B;
Console.WriteLine(array[B-1]);
B++;
}
