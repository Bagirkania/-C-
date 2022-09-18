Console.WriteLine("Введите число a! ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b! ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c! ");
int c = Convert.ToInt32(Console.ReadLine());

int[] numbers = { a, b, c };

int max = numbers.Max();
Console.WriteLine($"Max: {max}");

