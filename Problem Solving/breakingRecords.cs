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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        //https://www.hackerrank.com/challenges/breaking-best-and-worst-records
        
        int HigScore = scores[0], LowScore = scores[0];
        int cH = 0, cL =0;
        
        foreach(int x in scores)
        {
            if(HigScore <x)
            {
                HigScore= x;
                  cH++;
            }else if(LowScore > x)
            {
                LowScore = x;
                cL++;
            }
            Console.WriteLine($"ch = {cH} | cl = {cL}");
        }        
        return new int[] {cH, cL};
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}