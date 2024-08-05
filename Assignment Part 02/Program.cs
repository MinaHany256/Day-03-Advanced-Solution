using System.Collections;
using System.Collections.Generic;

namespace Assignment_Part_02
{
    internal class Program
    {
        #region 1. Given an array of integers, count the frequency of each element using a hash table.

        //public static Dictionary<int, int> CountFrequency(int[] Arr)
        //{
        //    Dictionary<int, int> FrequencyDictionary = new Dictionary<int, int>();

        //    foreach (int i in Arr)
        //    {
        //        if (FrequencyDictionary.ContainsKey(i))
        //            FrequencyDictionary[i]++;
        //        else
        //            FrequencyDictionary[i] = 1;
        //    }
        //    return FrequencyDictionary;
        //} 
        #endregion

        #region 2. You have a hashtable where its values are integers, find the key associated with the highest value.

        //public static int FindHighestValue(Dictionary<int, int> hashtable)
        //{
        //    int HighestKey = 0;
        //    int highestValue = 0;
        //    foreach (var item in hashtable)
        //    {
        //        if (item.Value > highestValue)
        //        {
        //            highestValue = item.Value;
        //            HighestKey = item.Key;
        //        }
        //    }

        //    return HighestKey;

        //}

        #endregion

        #region 3. You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue Note: if the targetValue not found print(“Key not found”)

        //public static Queue FindTargetValue(Dictionary<string, string> dictionary, string TargetValue)
        //{
        //    Queue queue = new Queue();
        //    foreach (var item in dictionary)
        //    {
        //        if (TargetValue.Equals(item.Value))
        //        {
        //            queue.Enqueue(item.Key);
        //        }
        //    }

        //    return queue;
        //}

        #endregion

        #region 4. Given an array of strings, group anagrams together.


        //public static void GroupAnagrams(string[] strings)
        //{
        //    Dictionary<string,string> dictionary = new Dictionary<string,string>();

        //    foreach (var s in strings)
        //    {
        //        char[] chars = s.ToCharArray();
        //        Array.Sort(chars);
        //        string SortedString = new string(chars);

        //        if(dictionary.ContainsKey(SortedString))
        //            dictionary[SortedString] += s;
        //        else
        //            dictionary[SortedString] = s;

        //    }

        //    foreach (var s in dictionary)
        //        Console.WriteLine($" {s.Value} ");

        //}

        #endregion

        #region 5. Given an array of integers, check if the array contains any duplicates.

        //public static int CheckDuplicates(int[] Arr)
        //{
        //    HashSet<int> hashset = new HashSet<int>();

        //    int Count = 0;
        //    foreach (int i in Arr)
        //    {
        //        if(hashset.Contains(i))
        //            Count++;
        //        else
        //            hashset.Add(i);
        //    }

        //    return Count;
        //}

        #endregion

        static void Main(string[] args)
        {
            #region 1. Given an array of integers, count the frequency of each element using a hash table.

            //int[] Numbers = { 1, 2, 2, 2, 3, 4, 5 };

            //Dictionary<int, int> ResultDictionary = CountFrequency(Numbers);

            //foreach (var i in ResultDictionary)
            //    Console.WriteLine($" Key : {i.Key} ::: Count : {i.Value} ");

            #endregion

            #region 2. You have a hashtable where its values are integers, find the key associated with the highest value.

            //Dictionary<int, int> hashtable = new Dictionary<int, int>()
            //{
            //    { 1,2 } ,
            //    { 2,3 } ,
            //    { 3,4 } ,
            //};

            //int ResultKey = FindHighestValue(hashtable);
            //Console.WriteLine($"Highest Key = {ResultKey}");

            #endregion

            #region 3. You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue Note: if the targetValue not found print(“Key not found”)

            //Dictionary<string, string> dictionary = new Dictionary<string, string>()
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana"},
            //    { "key3", "apple" }

            //};

            //Console.Write("Enter a Target Value : ");
            //string TargetValue = Console.ReadLine();
            //Queue ResultQueue = FindTargetValue(dictionary, TargetValue);

            //if (ResultQueue.Count == 0)
            //    Console.WriteLine("Key Not Found");

            //foreach (var item in ResultQueue)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Given an array of strings, group anagrams together.


            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //GroupAnagrams(words);

            #endregion

            #region 5. Given an array of integers, check if the array contains any duplicates.

            //int[] numbers = { 1, 2, 3, 4,2, 5, 6 };

            //int Count = CheckDuplicates(numbers);
            //Console.WriteLine($"Count of Duplicates = {Count} ");

            #endregion

            #region 6. Implement a SortedDictionary that stores student IDs (int) and their names (string). Perform operations like adding, removing, and retrieving student names.

            //SortedDictionary<int,string> sortedDictionary = new SortedDictionary<int,string>()
            //{
            //    {30, "Mina" },
            //    {10, "Hany" },
            //    {20, "Foad" }
            //};

            //bool flag;


            //flag = sortedDictionary.TryAdd(40, "Said");

            //if (!flag)
            //    Console.WriteLine("Item Already in the Dictionary");

            //sortedDictionary.Remove(30);

            //foreach (var item in sortedDictionary)
            //    Console.WriteLine($"{item.Key} ::: {item.Value} ");

            #endregion

            #region 7. Create an employee directory where employee IDs (int) are keys and employee names (string) are values. Use a SortedList to manage and retrieve employees in order of their IDs.

            //SortedList<int,string> sortedList = new SortedList<int,string>();

            //sortedList.Add(105, "Mina");
            //sortedList.Add(102, "Hany");
            //sortedList.Add(108, "Foad");

            //sortedList.Remove(105);
            //foreach (var i in sortedList)
            //    Console.WriteLine($"{i.Key} ::: {i.Value}");

            //int TargetId = 104;
            //if(!sortedList.TryGetValue(TargetId, out string value))
            //    Console.WriteLine($"Employe with Id : {TargetId} not Found ");
            //else
            //    Console.WriteLine($"Employe with Id : {TargetId} is {value} ");

            #endregion



        }
    }
}
