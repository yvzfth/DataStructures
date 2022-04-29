class InsertionSort
{
    public static void Main(string[] args)
    {
        int n = 1000000;
        int[] arr = new int[n];

        Random random = new Random(1);

        for (int i = 0; i < n; i++) arr[i] = random.Next(10000);

        foreach (int a in arr) Console.Write(a + " ");
        Console.WriteLine();

        for (int i = 1; i < arr.Length; i++)
        {
            int currentValue = arr[i];
            int j = i - 1;
            while (j >= 0 && currentValue < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = currentValue;

            foreach (int a in arr) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
}