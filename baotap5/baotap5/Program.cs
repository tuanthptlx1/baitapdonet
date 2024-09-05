using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu trong mang:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool isPalindrome = true;

        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Mang la doi xung (Palindrome).");
        }
        else
        {
            Console.WriteLine("Mang khong doi xung.");
        }
    }
}
