// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5->243
// 2, 4->16

Console.Clear();
Console.WriteLine("Please, enter two numbers: ");

string s_n_1 = Console.ReadLine();
int a = int.Parse(s_n_1);
string s_n_2 = Console.ReadLine();
int b = int.Parse(s_n_2);

int PowNum(int a, int b)
{
    int n_pow = a;
    for (int i = 1; i < b; i++)
    {
        n_pow *= a;
    }
    return n_pow;
}
Console.WriteLine($"{a}, {b} -> {PowNum(a, b)}");

