using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpProject4
{
    //자료구조
    public class ArrayTest
    {
        public void Test()
        {
            //배열
            int [] xp = new int[5]; // {10, 20, 30, 40, 100}
            xp[0] = 10;
            xp[1] = 20;
            xp[2] = 30;
            xp[3] = 40;
            xp[4] = 100;

            for (int i = 0; i<xp.Length; i++)
            {
                Console.WriteLine(xp[i]);
            }
        }
    
        //가변배열
        public void Test02()
        {
            //object
            //힙에 저장하는 것을 박싱(Boxing)
            //힙에 저장된것을 추출 언박싱(UnBoxing)

            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("문자");
            arrayList.Add(200.0f);

            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }
        }

        //리스트(List)
        public void Test03()
        {
            List<string> messages = new List<string>();
            messages.Add("Title");
            messages.Add("User Name");
            messages.Add("Level");
            messages.Add("Gold");

            for (int i=0; i<messages.Count; i++)
            {
                Console.WriteLine(messages[i]);
            }
        }
    
        //스택(Stack)
        /*
            후입선출 (LIFO)
        */
        public void Test04()
        {
            Stack<int> stack = new Stack<int>();

            for (int i=0; i<10; i++)
            {
                stack.Push(i);
            }

            while (stack.Count >0)
            {
                int value = stack.Pop();
                Console.Write($"{value} , ");
            }
        }
    
        //큐(Queue) : 선입선출 (FIFO)
        public void Test05()
        {
            Queue<int> queue = new Queue<int>();
            for (int i=0;i<10; i++)
            {
                queue.Enqueue(i);
            }

            foreach(var value in queue)
            {
                Console.WriteLine(value);
            }

        }
    
        //해시, 해시테이블 (Hash, HashTable)
        //키(Key), 값(Value)
        public void Test06()
        {
            Hashtable ht = new Hashtable();
            
            ht.Add("gold", 100);
            ht.Add("silver", 50);
            ht.Add("bronse", 10);

            if (ht.ContainsKey("gold"))
            {
                Console.WriteLine(ht["gold"]);
                ht["gold"] = 300;
                Console.WriteLine(ht["gold"]);
            }
        }

        //Dictionary 딕셔너리
        //박싱/언박싱 발생하지 않는다.
        public void Test07()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for(int i=0; i<3; i++)
            {
                dic.Add(i, $"i={i:000}");
            }

            foreach(var _dic in dic)
            {
                Console.WriteLine($"{_dic.Key} = {_dic.Value}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayTest arrayTest = new ArrayTest();
            //arrayTest.Test(); 
            //arrayTest.Test02();
            //arrayTest.Test03();
            //arrayTest.Test04();
            //arrayTest.Test05();
            //arrayTest.Test06();
            arrayTest.Test07();
        }
    }
}
