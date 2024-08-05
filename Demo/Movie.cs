using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class MovieComparer : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x?.Title.CompareTo(y?.Title) ?? (y is null ? 0 : -1);
        }
    }

    internal class MovieEqualityComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie? x, Movie? y)
        {
            return x?.Code.Equals(y?.Code) ?? (y is null ? true : false);
        }

        public int GetHashCode([DisallowNull] Movie obj)
        => obj.Code.GetHashCode();
           
        
    }

    internal class Movie : IEquatable<Movie> , IComparable<Movie>
    {
        public int Code { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }

        public Movie(int Code, string? Title, decimal Price)
        {
            this.Code = Code;
            this.Title = Title;
            this.Price = Price;

        }

        public override string ToString()
        => $"Code:{Code} , Title: {Title}, Price: {Price}";

        public override int GetHashCode()
        {
            return HashCode.Combine(Code, Title, Price);
        }

        public bool Equals(Movie? other)
        {
            if (other == null) return false;
            return this.Code.Equals(other.Code) && this.Title.Equals(other.Title) && this.Price.Equals(other.Price) ;
        }

        public int CompareTo(Movie? other)
        {
            if (other == null) return 1;

           return this.Code.CompareTo(other.Code) ;
        }
    }
}
