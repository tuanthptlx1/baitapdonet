using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot chuoi ky tu:");
        string input = Console.ReadLine();

        int count = 0;
        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                count++;
            }
        }

        Console.WriteLine($"So luong ky tu khong tinh khoang trang va dau cau la: {count}");
    }
}
