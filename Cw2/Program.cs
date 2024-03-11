public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine(average(new[] { 1, 2, 3}));
    }

    public static double average(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / (double)(arr.Length);
    }
}