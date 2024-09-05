internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap so luong phan tu mang ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = array[0];
        for (int i = 0; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i]  ;
            }

        }
        Console.WriteLine(" so lon nhat");
        Console.WriteLine(max);
    }
}