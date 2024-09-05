internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap so luong phan tu mang:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("nhap phan tu thu " + (i+1));
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);

    }
}