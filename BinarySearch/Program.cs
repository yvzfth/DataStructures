class BinarySearch
{
    static void Main()
    {
        int n = 100;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++) arr[i] = i;

        int target = 68;
        Console.WriteLine(binarySearch(arr, target, 0, arr.Length - 1));
    }
    static int binarySearch(int[] arr, int target, int l, int r)
    {
        if (r >= l)
        {
            int m = l + (r - l) / 2;
            if (arr[m] == target) return m;
            if (arr[m] > target) return binarySearch(arr, target, l, m - 1);
            return binarySearch(arr, target, m + 1, r);

        }
        return -1;
    }

}