class BubbleSort
{
    public static void Main()
    {

        int n = 100;
        int[] arr = new int[n];

        Random random = new Random(1);

        for (int i = 0; i < n; i++) arr[i] = random.Next(100);

        foreach (int a in arr) Console.Write(a + " ");
        Console.WriteLine();

        for (int i = arr.Length - 1; i > 0; i--)
        {
            bool change = false;

            for (int j = 0; j < i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    change = true;
                }
            }

            if (!change) break;

            foreach (int a in arr) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
}