using System.IO;
using System;

class Solution
{

    // Complete the reverseArray function below.
    static int[] reverseArray(int[] a)
    {
        int i = a.Length;
        int[] _reverse = new int[i];

        foreach (int x in a)
        {
            i--;
            _reverse[i] = x;
        }
        return _reverse;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] res = reverseArray(arr);

        textWriter.WriteLine(string.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}