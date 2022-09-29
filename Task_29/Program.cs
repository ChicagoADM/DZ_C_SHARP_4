//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Zadacha_29()
{
Console.Clear();    
Console.WriteLine("Введите первое число");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите четвертое число");
int a4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите пятое число");
int a5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите шестое число");
int a6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите седьмое число");
int a7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите восьмое число");
int a8 = Convert.ToInt32(Console.ReadLine());

int [] array = new int [8] {a1, a2, a3, a4, a5, a6, a7, a8};
Array.Sort(array);
int i = 0;
Console.Write("Отсортированный по модулю массив: ");
while(i < array.Length)
{
Console.Write(array[i] + ", ");
i++;
}
}
Zadacha_29();