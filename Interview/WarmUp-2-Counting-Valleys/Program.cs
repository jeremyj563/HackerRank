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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int valleys = 0;
        int position = 0;
        foreach(char c in s) {
            int nextPosition = c == 'D' ? position - 1 : position + 1;
            if (position == 0 && nextPosition == -1) { valleys++; }
            position = nextPosition;
        }

        return valleys;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
