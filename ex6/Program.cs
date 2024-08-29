using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào một số nguyên dương n: ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên dương.");
            Console.Write("Nhập vào một số nguyên dương n: ");
        }

        double S1 = 0.0;

        for (int i = 1; i <= n; i++)
        {
            S1 += 1.0 / i;
        }

        Console.WriteLine($"Tổng S1 = 1 + 1/2 + 1/3 + ... + 1/{n} = {S1}");
    }
}