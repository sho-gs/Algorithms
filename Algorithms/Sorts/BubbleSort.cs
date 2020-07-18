﻿namespace Algorithms.Sorts
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] items)
        {
            // Define the last index until which comparing & swapping continue
            for (var i = items.Length - 1; i > 0; i--)
            {
                // Define the flag to check whether or not swap has happened
                var swap = false;

                // Iterate over items starting with the first item until the item at the last index - 1
                for (var j = 0; j < i; j++)
                {
                    // If adjacent items are in the wrong order
                    // swap them and set the flag to true
                    if (items[j] > items[j + 1])
                    {
                        Swap(items, j, j + 1);
                        swap = true;
                    }
                }

                // Break out of the iteration if no swap has happened (meaning that the list is sorted)
                if (!swap)
                {
                    break;
                }
            }

            return items;
        }

        public static void Swap(int[] items, int index1, int index2)
        {
            var temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }
}