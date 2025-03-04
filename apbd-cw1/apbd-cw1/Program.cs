Console.WriteLine("Hello, World!");
Console.WriteLine("Commit 1");
Console.WriteLine("Commit 2");
Console.WriteLine("Commit 3");

static double GetAverage(int[] arr)
{
    double sum = 0;
    for (int i = 0; i<arr.Length; i++) {  sum += arr[i]; }
    return sum/arr.Length;
}

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(arr));