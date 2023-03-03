//напишите программу, которая на вчод принимает число , а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int a = 0;
while (a <= num){
    int rez = a % 2;
    if(rez > 0 ){
        a++;
    }
    else {
        Console.Write(a + " ,");
        a++;
    }

}
if (num < 0) {
    Console.WriteLine("ERROR");
}