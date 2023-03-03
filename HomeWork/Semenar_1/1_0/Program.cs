//напишите программу которая на вход принемает 2 числа и выдает, какое число больше, а какое меньше
Console.WriteLine("Введите первое число");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Второе число");
int num_2 = int.Parse(Console.ReadLine()!);

if(num_1 > num_2) {
    Console.WriteLine("Max = " + num_1 + ", " + "Min = " + num_2);
}

if(num_1 < num_2) {
    Console.WriteLine("Max = " + num_2 + ", " + "Min = " + num_1);
}

if(num_1 == num_2) {
    Console.WriteLine(num_1 + " = " + num_2);
}