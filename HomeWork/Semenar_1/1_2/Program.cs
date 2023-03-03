Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int rezult = num % 2;

if (rezult > 0 ){
    Console.WriteLine("No");
}
else Console.WriteLine("Yes");