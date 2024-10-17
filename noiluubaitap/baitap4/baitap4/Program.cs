

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu trong chuoi");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Reverse(array);
        Console.WriteLine("chuoi sau khi dc dao nguoc");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
