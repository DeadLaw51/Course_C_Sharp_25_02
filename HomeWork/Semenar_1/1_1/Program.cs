// напишите программу, которая принемает на вход 3 числа и выдает максимальное
Console.WriteLine("Введите первое число");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Второе число");
int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Третье число");
int num_3 = int.Parse(Console.ReadLine()!);

if(num_1 > num_2 ){
    if(num_1 > num_3 ){
        Console.WriteLine("Max = " + num_1);
    } 
    else Console.WriteLine("Max = " + num_3);
}

if(num_1 < num_2 ){
    if(num_2 > num_3 ){
        Console.WriteLine("Max = " + num_2);
    } 
    else Console.WriteLine("Max = " + num_3);
}