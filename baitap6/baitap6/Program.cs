using System;

class Program
{
    static void Main()
    {
        Console.Write("nhap vao chuoi: ");
        string inputString = Console.ReadLine();
        Console.Write("nhap chuoi ky tu can dem:");
        char characterToCount = Console.ReadLine()[0];
        int count = 0;

        foreach (char c in inputString)
        {
            if (c == characterToCount)
            {
                count++;
            }
        }

        Console.WriteLine($"ky tu '{characterToCount}' xuat hien {count} lan.");
    }
}
