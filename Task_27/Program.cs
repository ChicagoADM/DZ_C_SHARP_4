﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Zadacha_27()
{
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(a > 0)
{
    result = result + a % 10;
    a = a / 10;
}

Console.WriteLine($"Cумму цифр в числе = {result}");
}

Zadacha_27();