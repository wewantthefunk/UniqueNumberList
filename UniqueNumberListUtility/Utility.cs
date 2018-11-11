using System;
using System.Collections.Generic;

namespace UniqueNumberListUtility
{
    public class Utility
    {
        SortedList<int, int> _numberCount = new SortedList<int, int>();

        public int[] GetUnique (List<int[]> list)
        {
            List<int> result = new List<int>();

            foreach (int[] array in list)
            {
                for (int x = 0; x < array.Length; x++)
                {
                    if (_numberCount.ContainsKey(array[x]))
                    {
                        _numberCount[array[x]]++;
                    }
                    else
                    {
                        _numberCount.Add(array[x], 1);
                    }
                }
            }

            foreach(int number in _numberCount.Keys)
            {
                if (_numberCount[number] == 1)
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }
    }
}
