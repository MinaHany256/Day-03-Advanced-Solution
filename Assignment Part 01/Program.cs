using System.Collections;

namespace Assignment_Part_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array

            //int[] numbers = new int[5];


            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;

            //Console.WriteLine("Element at index 0: " + numbers[0]);
            //Console.WriteLine("Element at index 1: " + numbers[1]);



            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine("Element at index " + i + ": " + numbers[i]);


            //foreach (int number in numbers)
            //    Console.WriteLine(number);



            //string[] names = { "Ahmed", "Ali", "Omar" };


            //Console.WriteLine("Element at index 0: " + names[0]);
            //Console.WriteLine("Element at index 1: " + names[1]);



            //foreach (string name in names)
            //    Console.WriteLine(name);


            #endregion

            #region ArrayList
            //ArrayList arrayList = new ArrayList();


            //arrayList.Add(1);             
            //arrayList.Add("Hello");       
            //arrayList.Add(3.14);          
            //arrayList.Add(true);          


            //Console.WriteLine("Element at index 0: " + arrayList[0]); 
            //Console.WriteLine("Element at index 1: " + arrayList[1]); 



            //foreach (var item in arrayList)
            //    Console.WriteLine(item);



            //arrayList.Remove("Hello");
            //Console.WriteLine("After removing :");

            //foreach (var item in arrayList)
            //    Console.WriteLine(item);


            //arrayList.Insert(1, "World");
            //Console.WriteLine("After inserting: ");

            //foreach (var item in arrayList)
            //    Console.WriteLine(item);

            #endregion

            #region List<T>

            //List<int> numbers = new List<int>();


            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //numbers.Add(50);


            //Console.WriteLine("Element at index 0: " + numbers[0]);
            //Console.WriteLine("Element at index 1: " + numbers[1]);

            //foreach (int number in numbers)
            //    Console.WriteLine(number);



            //numbers.Remove(30);
            //Console.WriteLine("After removing 30:");

            //foreach (int number in numbers)
            //    Console.WriteLine(number);


            //numbers.Insert(2, 25);
            //Console.WriteLine("After inserting 25 at index 2:");


            //foreach (int number in numbers)
            //    Console.WriteLine(number);


            //bool Flag = numbers.Contains(40);
            //Console.WriteLine("List contains 40: " + Flag); 

            #endregion

            #region Dictionary

            //Dictionary<string, int> ages = new Dictionary<string, int>();


            //ages.Add("Mina", 30);
            //ages.Add("Hany", 25);
            //ages.Add("Foad", 35);


            //Console.WriteLine("Mina's age: " + ages["Mina"]);


            //if (ages.ContainsKey("Hany"))
            //    Console.WriteLine("Hany's age: " + ages["Hany"]);




            //foreach (var item in ages)
            //    Console.WriteLine($"{item.Key} ::: {item.Value} ");


            //ages.Remove("Foad");
            //Console.WriteLine("After removing Charlie:");

            //foreach (var item in ages)
            //    Console.WriteLine($"{item.Key} ::: {item.Value} ");


            //if (ages.TryGetValue("Mina", out int Age))
            //    Console.WriteLine("Mina's age: " + Age);

            //ages["Mina"] = 26;


            #endregion

            #region SortedList

            //SortedList<string, int> sortedAges = new SortedList<string, int>();


            //sortedAges.Add("Mina", 35);
            //sortedAges.Add("Hany", 30);
            //sortedAges.Add("Foad", 25);




            //if (sortedAges.ContainsKey("Mina"))
            //{
            //    Console.WriteLine("Mina's age: " + sortedAges["Mina"]); 
            //}

            //foreach (var item in sortedAges)
            //    Console.WriteLine($"{item.Key} ::: {item.Value} ");



            //sortedAges.Remove("Mina");

            //foreach (var item in sortedAges)
            //    Console.WriteLine($"{item.Key} ::: {item.Value} ");


            #endregion

            #region HashSet

            //HashSet<int> numbers = new HashSet<int>();

           
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //numbers.Add(50);

           
            //bool added = numbers.Add(20);
            //Console.WriteLine("Was 20 added again? " + added);

            //foreach (var item in numbers)
            //    Console.WriteLine($"{item}");



            //if (numbers.Contains(30))
            //{
            //    Console.WriteLine("HashSet contains 30");
            //}

           
            //numbers.Remove(40);
            //Console.WriteLine("After removing 40:");

            //foreach (var item in numbers)
            //    Console.WriteLine($"{item}");

           
            //HashSet<int> otherNumbers = new HashSet<int> { 30, 50, 60, 70 };

          
            //numbers.UnionWith(otherNumbers);
            //Console.WriteLine("After UnionWith otherNumbers:");

            //foreach (var item in numbers)
            //    Console.WriteLine($"{item}");

            
            //numbers.IntersectWith(otherNumbers);

            //foreach (var item in numbers)
            //    Console.WriteLine($"{item}");

           
            //numbers.ExceptWith(otherNumbers);

            //foreach (var item in numbers)
            //    Console.WriteLine($"{item}");

            #endregion
        }
    }
}
