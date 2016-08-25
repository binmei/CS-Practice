/**
 * I understood this question to be finding a subset of N largest numbers from 
 * an unordered list. My basic approach was to use MergeSort to order the list 
 * in descending order, and then grab the N largest elements.
 * 
 * The reason why I am using MergeSort is because it's O(nLog(n)) time complexity.
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace FindNLargest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Array Element e.g. 5,10,15,2,3 : ");
            string sInputArray = Console.ReadLine();

            Console.Write("Enter Element To Return e.g. 3 : ");
            int sArrayElement = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();
            string[] sValue = sInputArray.Split(',');

            for (int i = 0; i < sValue.Length; i++)
            {
                list.Add(Convert.ToInt32(sValue[i]));
            }

            //Using my implementation of the merge sort on the entered list of numbers.
            List<int> tempList = MyMergeSort(list);
            tempList.Reverse();


            var vResult = FindTopN(tempList, sArrayElement);

            string vTempResult = "";
            foreach (var vItem in vResult)
            {
                vTempResult += vItem + ",";
            }
            Console.Write(vTempResult.TrimEnd(','));

            Console.ReadLine();
        }

        /// <summary>
        /// After the List is sorted by using MergeSort, FindTopN method returns
        /// N largest elements from the List.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static IEnumerable<int> FindTopN(IEnumerable<int> list, int n)
        {
            List<int> listResult = new List<int>();
            int iCount = 0;
            foreach (int value in list)
            {
                if (iCount == n)
                {
                    break;
                }
                else
                {
                    iCount++;
                    listResult.Add(value); //adding largest number to result list.
                }
            }
            return listResult;
        }


        /// <summary>
        /// My implementation of the mergesort method, using recursion.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> MyMergeSort(List<int> input)
        {
            List<int> resList = new List<int>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (input.Count <= 1)
                return input;

            int midpoint = input.Count / 2; //creating a mid point to divide the list in half
            for (int i = 0; i < midpoint; i++)
                left.Add(input[i]);
            for (int i = midpoint; i < input.Count; i++)
                right.Add(input[i]);

            left = MyMergeSort(left); //Using Recursion on "left" side of the list
            right = MyMergeSort(right); //Using Recursion on "right" side of the list
            resList = Merge(left, right);

            return resList;
        }


        /// <summary>
        /// The Merge method for MergeSort
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    if (left[0] < right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }

                else if (left.Any())
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }

                else if (right.Any())
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            return result;
        }
    }
}
