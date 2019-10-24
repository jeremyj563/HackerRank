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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        int hops = 0;
        int maxIndex = c.Count() - 1;

        for (var i=0; i<maxIndex; i++) {
            if (i+2 <= maxIndex) {
                if (c[i+2] == 0) { 
                    i++; hops++;
                    continue;
                 }
            }
            if (i+1 <= maxIndex) {
                if (c[i+1] == 0) hops++;
            }
        }

        return hops;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int result = jumpingOnClouds(c);

        Console.WriteLine(result);
    }
}