int number;

while (true)
{
    Console.Write("Nhập vào một số nguyên: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out number))
    {
        if (number > 0)
        {
            Console.WriteLine($"Bạn đã nhập số nguyên dương: {number}");
            break;
        }
        else
        {
            Console.WriteLine("Số vừa nhập không phải là số nguyên dương. Vui lòng thử lại.");
        }
    }
    else
    {
        Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên.");
    }
}
