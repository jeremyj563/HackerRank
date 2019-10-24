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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        var groups = ar.GroupBy(x => x);

        int matches = 0;
        foreach (var group in groups) {
            int count = group.Count();

            if (count % 2 == 0) {
                // an even grouping
                matches += count / 2;
            } else if ((count - 1) > 0 ) {
                // an odd grouping with at least one pair
                matches += (count - 1) / 2;
            }
        }

        return matches;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}