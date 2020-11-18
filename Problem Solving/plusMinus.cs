using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        
    // https://www.hackerrank.com/challenges/plus-minus

        int pos = 0, neg = 0, zer = 0;
        
        foreach(int x in arr)
        {
            if(x < 0)
            {
                neg++;
            }
            else if(x > 0)
            {
                pos++;
            }
            else if(x == 0)
            {
                zer++;
            }
        }
        
        Console.WriteLine($"{(float)pos / arr.Length}");
        Console.WriteLine($"{(float)neg / arr.Length}");
        Console.WriteLine($"{(float)zer / arr.Length}");
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
