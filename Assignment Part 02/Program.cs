using System.Collections;

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

           

        }
    }
}
