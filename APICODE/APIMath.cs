/*
using System;
using System.Text.RegularExpressions;

namespace RDCAPIPLUGININTERFACE.Math
{
    public class APIMath
    {
        static public int Max(int a, int b) => ((a > b) ? a : b);
        static public int Max(int[] array)
        {
            int MaxNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > MaxNum)
                {
                    MaxNum = array[i];
                }
            }
            return MaxNum;
        }
        static public int Min(int a, int b) => ((a < b) ? b : a);
        static public int Min(int[] array)
        {
            int MinNum = 0xfffffff;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < MinNum)
                {
                    MinNum = array[i];
                }
            }
            return MinNum;
        }
        static public Match Re(string re, string input)
        {
            return Regex.Match(input, re);
        }
    }
}
*/