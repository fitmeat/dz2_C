Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7");
int n = int.Parse(Console.ReadLine());
while(n<1 || n>7){
    Console.WriteLine("Это не похоже на цифру от 1 до 7! Пробуй еще:");
    n = int.Parse(Console.ReadLine());
}
switch(n){
    case 1: case 2: case 3: case 4: case 5: Console.WriteLine("Будний"); break;
    case 6: case 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("ERROR"); break;
}