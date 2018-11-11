using System;
using System.Collections.Generic;
using UniqueNumberListUtility;

namespace UniqueNumberLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> lists = new List<int[]>();

            int[] one = new int[] { 1, 2, 3 };

            int[] two = new int[] { 2, 3, 4};

            int[] three = new int[] { 3, 5, 6 };

            lists.Add(one);
            lists.Add(two);
            lists.Add(three);

            Utility utility = new Utility();

            int[] result = utility.GetUnique(lists);

            foreach(int i in result)
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }
    }
}
