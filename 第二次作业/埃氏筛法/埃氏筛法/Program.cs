﻿using System;

namespace 埃氏筛法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]aa = new int[101];
            aa[0] = aa[1] = 1;
            aa[2] = 0;
            int k = 2, ti = 0;
            while (ti < 101)
            {
                for (int i = 1; i < aa.Length; i++) //将不是素数的数筛出
                {
                    if (i % k == 0 && i != k)
                        aa[i] = 1;//不符合要求的全部置为1
                }

                for (int i = 1; i < aa.Length; i++) //将筛选后的第一个数当做新的筛子
                {
                    if (i > k && aa[i] == 0)
                    {
                        k = i;
                        break;
                    }
                }
                ti++;
            }

            for (int i = 1; i < aa.Length; i++)
                if (aa[i] == 0) Console.WriteLine(i); 
        }

    }
}
