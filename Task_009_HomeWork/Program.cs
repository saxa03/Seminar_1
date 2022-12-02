// вывести все четные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine());
int B = 2;

while ( B <= N )

{
    if ( B%2 == 0)
    
    Console.WriteLine($"{B}");
    B++;
}