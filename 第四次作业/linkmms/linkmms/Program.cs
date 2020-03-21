using System;
using System.Collections.Generic;
using System.Linq;
namespace linkmms
{// 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action <T> action)
        {
            for (Node<T> node = Head;
                  node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> list = new GenericList<int>();
            
            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }
            //列出
            list.ForEach(x => Console.Write(x+" "));
            Console.WriteLine("");
            //最大值
            int max = -2147483648;
            list.ForEach(x => { if (x>max) max = x; }) ;
            Console.WriteLine($"最大值为:{max}");
            int min = 2147483647;
            list.ForEach(x => { if (x<min) min = x; });
            Console.WriteLine($"最小值为:{min}");
            int sum = 0;
            list.ForEach(x=> { sum += x; });
            Console.WriteLine($"总和为:{sum}");

        }
    }
}
