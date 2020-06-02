using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> ObjectList = new List<object>();
            ObjectList.Add(7);
            ObjectList.Add(28);
            ObjectList.Add(-1);
            ObjectList.Add(true);
            ObjectList.Add("chair");
            int MySum = 0;
            for(int i=0; i<ObjectList.Count; i++)
            {
                System.Console.WriteLine(ObjectList[i]);
                if(ObjectList[i] is int)
                {
                    MySum = MySum+(int)ObjectList[i];
                }
            }
            System.Console.WriteLine(MySum);
        }
    }
}
