using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

public class SinhVien
{
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }

    public SinhVien() { }
    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap MSSV: ");
        MSSV = Console.ReadLine();

        Console.Write("Nhap diem trung binh: ");
        DiemTrungBinh = Convert.ToDouble(Console.ReadLine());
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Ho ten: {HoTen}, MSSV: {MSSV}, Diem trung binh: {DiemTrungBinh}");
    }
}

public class DanhSachSinhVien
{
    private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

    public void ThemSinhVien(SinhVien sv)
    {
        danhSachSinhVien.Add(sv);
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sach sinh vien:");
        foreach (var sv in danhSachSinhVien)
        {
            sv.HienThiThongTin();
        }
    }

    public void TimSinhVienTheoMSSV(string mssv)
    {
        var sv = danhSachSinhVien.FirstOrDefault(s => s.MSSV == mssv);
        if (sv != null)
        {
            Console.WriteLine("Thong tin sinh vien tim thay:");
            sv.HienThiThongTin();
        }
        else
        {
            Console.WriteLine($"Khong tim thay sinh vien voi MSSV {mssv}");
        }
    }

    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        if (danhSachSinhVien.Count == 0)
        {
            return null;
        }

        var svCaoNhat = danhSachSinhVien.OrderByDescending(s => s.DiemTrungBinh).First();
        return svCaoNhat;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DanhSachSinhVien ds = new DanhSachSinhVien();
        Console.WriteLine("nhap so luong sinh vien:");
        int n= Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin cho sinh vien thu {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            ds.ThemSinhVien(sv);
        }

        Console.WriteLine("\nDanh sach sinh vien da nhap:");
        ds.HienThiDanhSach();

        SinhVien svCaoNhat = ds.TinhDiemTrungBinhCaoNhat();
        if (svCaoNhat != null)
        {
            Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
            svCaoNhat.HienThiThongTin();
        }

        Console.Write("\nNhap MSSV sinh vien muon tim: ");
        string mssvCanTim = Console.ReadLine();
        ds.TimSinhVienTheoMSSV(mssvCanTim);
    }
}
