using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> myList = new List<List<int>>();

            List<int> list1 = new List<int>();
            list1.Add(1);
            myList.Add(list1);

            List<int> list2 = new List<int>();
            list2.Add(2);
            list2.Add(2);
            myList.Add(list2);

            List<int> list3 = new List<int>();
            list3.Add(3);
            list3.Add(3);
            list3.Add(3);
            myList.Add(list3);

            List<int> list4 = new List<int>();
            list4.Add(4);
            list4.Add(4);
            list4.Add(4);
            list4.Add(4);
            myList.Add(list4);

            List<int> list5 = new List<int>();
            list5.Add(5);
            list5.Add(5);
            list5.Add(5);
            list5.Add(5);
            list5.Add(5);
            myList.Add(list5);

            for (int i = 0; i < myList.Count; i++)
            {
                List<int> list = myList[i];
                for (int j = 0; j < list.Count; j++)
                {
                    Console.WriteLine(list[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
/*List<string> l = new List<string>();
            l.Add("11");
            l.Add("11");
            l.Add("11");
            l.Add("11");
            l.Add("11");
            l.Add("11");
            l.Add("11");

            foreach (object i in l)
            {
                Console.Write("\t", i.ToString());
            }
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("2");
            al.Add(2.5);
            al.Add(true);

            al.Add(l);
            l.Add("21");
            l.Add("31");
            al.Add(l);
            l.Clear();
            al.Add(l);

            foreach (List<string> i in al)
            {
                foreach (object i1 in i)
                {
                    Console.WriteLine(i1);
                }
            }
            Console.ReadLine();

            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast("1");
            ll.AddLast("2");
            ll.AddLast("3");
            ll.AddLast("4");
            ll.AddLast("5");
            ll.AddLast("6");

            
            foreach (object i in ll)
            {
                Console.WriteLine(i);
            }*/