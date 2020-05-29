using System;

namespace 质数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字：");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("质数因子为：");
            
            if(num<=1)
            {
                Console.WriteLine("质数因子不存在，请输入一个大于等于2的数字。");
                return;
            }
           
            for (int i = 2; i <= num;i++)
            {
                for(; num%i==0;num/=i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
