using System.Collections;

namespace Demo
{
    class StringEqualityComaprer : IEqualityComparer
    {
        public bool Equals(object? x, object? y)
        {
            string? strX = x as string;
            string? strY = y as string;

            return strX?.ToLower().Equals(strY) ?? (strY is null ? true : false);

        }

        public int GetHashCode(object obj)
        {
            string? other = obj as string;

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
        }
    }
}
