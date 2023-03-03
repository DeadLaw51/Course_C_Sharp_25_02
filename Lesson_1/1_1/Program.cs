// 1_1
string a = Console.ReadLine()!;
string b = Console.ReadLine()!;

int znach_a = int.Parse(a);
int znach_b = int.Parse(b);

if(znach_a == znach_b * znach_b )
    Console.WriteLine("yes");
else Console.WriteLine("no");