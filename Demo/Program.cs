using System.Collections;

namespace Demo
{
    class StringEqualityComaprer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return x?.ToLower().Equals(y) ?? (y is null ? true : false);
        }

        public int GetHashCode(string other)
        {

            if (other is null) return 0;

            return other.ToLower().GetHashCode();
        }
    }


    class Employee01
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

    }
    class Employee02
    {
        public int Code { get; set; }
        public string Title { get; set; } = null!;

        public override int GetHashCode()
        {
            return HashCode.Combine(Code, Title);
        }
    }

    //class CustomHashCodeProvider : IHashCodeProvider
    //{
    //    public int GetHashCode(object obj)
    //    {
    //        string? other = obj as string;

    //        if (other is null) return 0;

    //        return other.ToLower().GetHashCode();
    //    }
    //}
    //class CustomComparer  : IComparer
    //{
    //    public int Compare(object? x, object? y)
    //    {
    //        string? strX = x as string;
    //        string? strY = y as string;

    //        return strX?.ToLower().CompareTo(strY) ?? (strY is null ? 0 : -1);

    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collection - Hashtable 

            //string Name = "Ahmed";

            //Hashtable Note = new Hashtable(new CustomHashCodeProvider() , new CustomComparer() )  // Old Way
            //Hashtable Note = new Hashtable(new StringEqualityComaprer())
            //{
            //   {"Ahmed", 333},
            //   {"Omars", 444},
            //   {"Amany", 888},
            //};

            // Note.Add("Ahmed", 999);  // Invalid : Key Must Be UNIQUE
            //Name = "Mohamed";

            #region Add
            //// Unsafe Code
            //Note.Add("ahmed", 999);

            //// Safe Code 
            //if(!Note.ContainsKey("Ahmed"))
            //    Note.Add("ahmed", 999); 
            #endregion

            #region GET

            //Console.WriteLine(Note["Manar"] ?? "NA");

            //Note.TryGetValue("Manar", out int Value); // in Dictionary 
            #endregion

            //foreach (DictionaryEntry Person in Note)
            //    Console.WriteLine($"{Person.Key} ::: {Person.Value}");



            #endregion

            #region Generic Collections - Dictionary [Hashtable]

            #region Example 01
            //Dictionary<string, int> Note = new Dictionary<string, int>()
            //{
            //    {"Ahmed", 123},
            //    {"Nadia", 456},
            //    {"Omars", 789},
            //};

            #region Add & Set
            //// Unsafe Code
            //Note.Add("Ahmed", 222);

            //// Add Or Set
            //Note["Ahmed"] = 222;   // if not found will add , if found will update value

            //// Safe Code (First Way)
            //if (!Note.ContainsKey("Ahmed"))
            //    Note.Add("Ahmed", 222);


            //// Safe Code (Second Way)
            //Note.TryAdd("Ahmed", 222); 
            #endregion

            #region Get

            // Unsafe Code
            //Console.WriteLine(Note["Ali"]);

            //if(Note.ContainsKey("Ali"))
            //    Console.WriteLine(Note["Ali"]);

            //Note.TryGetValue("Ahmed", out int value);
            //Console.WriteLine(value);


            #endregion

            #region Go Through All Items
            //foreach (var person in Note)
            //    Console.WriteLine($"{person.Key} ::: {person.Value}"); 
            #endregion


            #region Go Through Dictionary Entries
            // Note.Add("Ahmed", 111); // Invalid: Key Must be Unique

            //Dictionary<string, int> Note02 = new Dictionary<string, int>(Note, new StringEqualityComaprer() );
            //Note02.Add("ahmed", 555);

            //KeyValuePair<string, int>[] keyValuePairs =
            //    {
            //    new KeyValuePair<string, int>("Mona",999),
            //    new KeyValuePair<string, int>("Alii",222),
            //    new KeyValuePair<string, int>("Amrr",777),
            //    };

            //Dictionary<string, int> Note02 = new Dictionary<string, int>(keyValuePairs) 
            #endregion; 
            #endregion


            #region Example 02
            //Dictionary<Employee, string> Employees = new Dictionary<Employee, string>()
            //{
            //    {new Employee (10,"Ahmed",6000) , "Employee with Id: 10, Name: Ahmed" },
            //    {new Employee (20,"Nadia",4000) , "Employee with Id: 20, Name: Nadia" },
            //};

            //Employees.Add(new Employee(10, "Ahmed", 6000), "Employee with Id.......");

            //foreach (var  emp in Employees)
            //    Console.WriteLine($"{emp.Key}"); 
            #endregion


            #endregion
        }
    }
}
