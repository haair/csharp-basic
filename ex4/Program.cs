Console.Write("Nhập vào một số nguyên n: ");
int n;

while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên.");
    Console.Write("Nhập vào một số nguyên n: ");
}

if (IsPrime(n))
{
    Console.WriteLine($"{n} là số nguyên tố.");
}
else
{
    Console.WriteLine($"{n} không phải là số nguyên tố.");
}


static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;

    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}