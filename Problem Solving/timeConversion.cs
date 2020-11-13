using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
         
         // https://www.hackerrank.com/challenges/time-conversion

        int hour = Convert.ToInt16(s.Substring(0, 2));
        string hourAux = String.Empty;
                
        if(s.Contains("PM"))
        {
            if(hour == 12)
                hourAux = "12";
            else
            {
                hour = hour + 12;
                hourAux = Convert.ToString(hour);
            }            
        }
        else
        {
            if(hour == 12)
                hourAux = "00";
            else
            {
                hourAux = s.Substring(0, 2); 
                s = s.Substring(0, 8);
            }
        }
        
        string[] timeFormat = {hourAux, s.Substring(2, 6)};
        s = string.Concat(timeFormat);
        
        return s;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}