Console.Write("Nhập vào một số nguyên dương n (năm): ");
int n;

while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên dương.");
    Console.Write("Nhập vào một số nguyên dương n (năm): ");
}

if (IsLeapYear(n))
{
    Console.WriteLine($"{n} là năm nhuận.");
}
else
{
    Console.WriteLine($"{n} không phải là năm nhuận.");
}


static bool IsLeapYear(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}