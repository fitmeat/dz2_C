Console.Clear();
Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int a = (n/10)%10;
Console.WriteLine($"Вторая цифра числа - {a}"); 

