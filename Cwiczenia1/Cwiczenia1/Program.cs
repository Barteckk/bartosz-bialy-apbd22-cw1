// See https://aka.ms/new-console-template for more information
static double GetAverage(int[] arr) {
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i];
    }
    return result;
}

int[] arr = { 15,12,54,32 };
Console.WriteLine(GetAverage(arr));
