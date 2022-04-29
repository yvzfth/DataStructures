class MergeSort
{
    // Merges two subarrays of []arr.
    // First subarray is arr[l..m]
    // Second subarray is arr[m+1..r]
    public static void merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two
        // subarrays to be merged
        int n1 = m - l + 1;
        int n2 = r - m;

        // Create temp arrays
        int[] left = new int[n1];
        int[] right = new int[n2];

        // Copy data to temp arrays
        int i, j;
        for (i = 0; i < n1; i++)

            left[i] = arr[l + i];

        for (j = 0; j < n2; j++)

            right[j] = arr[m + j + 1];


        // Merge the temp arrays

        // Initial indexes of first
        // and second subarrays
        i = j = 0;

        // Initial index of merged
        // subarray array
        int k = l;
        while (i < n1 && j < n2)
        {
            if (left[i] < right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements
        // of L[] if any
        while (i < n1)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        // Copy remaining elements
        // of R[] if any
        while (j < n2)
        {
            arr[k] = right[j];
            j++;
            k++;
        }

    }

    // Main function that
    // sorts arr[l..r] using
    // merge()
    public static void mergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            mergeSort(arr, l, m);
            mergeSort(arr, m + 1, r);
            merge(arr, l, m, r);
            foreach (int a in arr) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
    public static void Main()
    {
        int[] arr = { 5, 4, 8, 3, 7, 9, 1, 6, 2, 11, 0 };
        mergeSort(arr, 0, arr.Length - 1);
        foreach (int a in arr) Console.Write(a + " ");
        Console.WriteLine();
    }
}