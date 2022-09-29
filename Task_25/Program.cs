// Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void Zadacha_25()
{
Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 1;
while(i<b+1)
{
result = result * a;
i++;
}
Console.Write($"число A в степень B = {result}");
}
Zadacha_25();