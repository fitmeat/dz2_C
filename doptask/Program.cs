Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int max1 = n, max2 = -1;
while(n!=0){
    n = int.Parse(Console.ReadLine());
    if(n>max1){
        max2 = max1;
        n = max1;
    } else if(n>max2){
        max2 = n;
    }
}
Console.WriteLine($"max2 = {max2}");