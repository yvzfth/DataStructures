class SelecionSort
{
    public static void Main(string[] args)
    {
        int n = 1000;
        int[] arr = new int[n];

        Random random = new Random(1);

        for (int i = 0; i < n; i++) arr[i] = random.Next(1000);
        foreach (int a in arr) Console.Write(a + " ");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i];
            int index = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    index = j;
                    min = arr[j];

                }
            }

            arr[index] = arr[i];
            arr[i] = min;

            foreach (int a in arr) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
}