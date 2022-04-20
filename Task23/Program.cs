Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
for (int index = 1; number >= index; index ++)
{
    int newNumber = Cube(index);
    Console.WriteLine($"{index} -> {newNumber}" );
}



int Cube(int index)
{
    return index = index * index * index; 
}