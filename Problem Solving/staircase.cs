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

    // Complete the staircase function below.
    static void staircase(int n) {
        
        // https://www.hackerrank.com/challenges/staircase
        
        for(int x = 1; x <= n; x++)
        {
            for(int y = n-1; y >= x; y--)
            {
                Console.Write(" ");
            }
            for(int z = 1; z <= x; z++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
