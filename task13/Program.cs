Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if(n<100 && n>-100){
    Console.WriteLine("Третьей цифры нет");
} 
else{
    int third_n = n%10;
    Console.WriteLine($"Третья цифра числа - {third_n}");
}
