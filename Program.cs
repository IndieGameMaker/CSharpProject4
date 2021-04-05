using System;
using System.Collections;

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
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("문자");
            arrayList.Add(100.0f);

            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayTest arrayTest = new ArrayTest();
            arrayTest.Test(); 
        }
    }
}
