// Рекурсия
/*
void OpenMatryoshka(int size)
{
    Console.WriteLine($"Opening matryoshka of size {size}...");//Базовый случай - самая маленькая матрешка
    if (size == 1)
    {
        Console.WriteLine("Reached the smallest matryoshka!");
        return;
    }
    OpenMatryoshka(size - 1);
}
OpenMatryoshka(5);


void OpenMatryoshka(int size)
{
if (size == 1)
    {
       Console.WriteLine("Smallest!");
        return;
    }
OpenMatryoshka(size - 1);
Console.WriteLine($"Opening matryoshka of size {size}...");
}
OpenMatryoshka(5);

Вычислить факториал от натурального числа N
*/

int Fact(int n)
{
   if (n ==  1 || n == 0)
   {
    System.Console.WriteLine($"Stop: {n}");
    return 1;
   
   }
    return n * Fact(n - 1);
    
}
System.Console.WriteLine(Fact(5));