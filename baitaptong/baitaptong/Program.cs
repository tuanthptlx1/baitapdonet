using System;
using System.Linq;

namespace Console_tonghop6
{
    class Program
    {
        // b1
        void bai1()
        {
            int tong = 0;
            int n;
            Console.WriteLine("nhap so phan tu cua mang");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("nhap phan tu cua mang");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in a)
            {
                tong += i;
            }
            Console.WriteLine($"tong cua mang : {tong}");
        }

        //b2
        void bai2()
        {
            Console.WriteLine("nhap chuoi ki tu:");
            string v1 = Console.ReadLine();
            v1 = v1.ToLower();
            int dem = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] >= 'a' && v1[i] <= 'z')
                {
                    dem++;
                }
            }
            Console.WriteLine($"so luong ki tu trong chuoi:{dem}");
        }

        //b3
        void bai3()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"phan tu lon nhat cua mang : {max}");
        }

        //b4
        void bai4()
        {
            Console.WriteLine("Nhập chuỗi ký tự:");
            string input = Console.ReadLine();
            string reversedString = new string(input.Reverse().ToArray());
            Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");
        }

        //b5
        void bai5()
        {
            Console.WriteLine("nhap so luong phan tu:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("nhap mang:");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int size = a.Length - 1;
            int dem = 0;
            int dk = a.Length / 2;
            Console.WriteLine("kiem tra xem mang co doi xung khong:");
            for (int i = 0; i < dk; i++)
            {
                if (a[i] == a[size])
                {
                    dem++;
                }
                size--;
            }

            if (dem == dk)
            {
                Console.WriteLine("mang nay doi xung");
            }
            else
            {
                Console.WriteLine("mang nay khong doi xung");
            }
        }

        //b6
        void bai6()
        {
            Console.WriteLine("nhap chuoi ki tu:");
            string names = Console.ReadLine();
            Console.WriteLine("ki tu can tim so lan:");
            char kitu = Convert.ToChar(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == kitu)
                {
                    dem++;
                }
            }
            Console.WriteLine($"ki tu '{kitu}' xuat hien {dem} lan");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int x1;
            do
            {
                Console.WriteLine("chon bai de chay (1-6), hoac nhap 0 de thoat:");
                x1 = Convert.ToInt32(Console.ReadLine());

                if (x1 == 1)
                {
                    Console.WriteLine("Bai 1");
                    p.bai1();
                }
                else if (x1 == 2)
                {
                    Console.WriteLine("Bai 2");
                    p.bai2();
                }
                else if (x1 == 3)
                {
                    Console.WriteLine("Bai 3");
                    p.bai3();
                }
                else if (x1 == 4)
                {
                    Console.WriteLine("Bai 4");
                    p.bai4();
                }
                else if (x1 == 5)
                {
                    Console.WriteLine("Bai 5");
                    p.bai5();
                }
                else if (x1 == 6)
                {
                    Console.WriteLine("Bai 6");
                    p.bai6();
                }
                else if (x1 == 0)
                {
                    Console.WriteLine("Thoát chương trình.");
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Xin thử lại.");
                }
            }
            while (x1 != 0);
        }
    }
}
