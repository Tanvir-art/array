using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the Array  size");
            //int size = Convert.ToInt32(Console.ReadLine());

            //int[] myArray = new int[5];
            //myArray[0] = 20;
            //myArray[1] = 30;
            //myArray[2] = 40;
            //myArray[3] = 50;
            //myArray[4] = 60;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(123);
            //myArrayList.Add("abc");
            //myArrayList.Add(1230.50);
            //myArrayList.Add('a');
            //Console.WriteLine(myArrayList.Count);
            //Console.WriteLine(myArrayList.Contains(123));
            //foreach (var item in myArrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //myArrayList.Remove(123);
            //myArrayList.RemoveAt(2);
            //Console.WriteLine(myArrayList.Count);
            //foreach (var item in myArrayList)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> mylist = new List<string>();
            mylist.Add("Tanvir");
            mylist.Add("Hasan");
            mylist.Add("Ovi");
            Console.WriteLine("The list size:"  +mylist.Count);
            List<string> newlist = new List<string>();
            mylist.Add("Tan");
            mylist.Add("an");
            mylist.Add("vi");
            mylist.AddRange(newlist);
            Console.WriteLine("The list size Now:" + mylist.Count);
            foreach (var data in mylist)
            {
                Console.WriteLine(data);
            }
        }
    }
}
