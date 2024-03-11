public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine(average(new[] { 1, 2, 3 }));
        Console.WriteLine(max(new[] { 53, 12312, 10, 123, 52, 1, -5 }));
    }

    public static double average(int[] arr)
    {
        int sum = 0;

        for (int c = 0; c < arr.Length; c++)
        {
            sum += arr[c];
        }

        return sum / (double)(arr.Length);
    }

    public static int max(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
                max = arr[i];
        }

        return max;
    }
}