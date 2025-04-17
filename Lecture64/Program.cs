using System;
using System.Linq;
namespace Lecture64
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Mustafa", "Shuja", "Zia", "Ibrahim",
                    "Ali", "Sabir","Aziz" };
            
            bool myValue = true;

            //var query = names.Where(x => x.Length > 4).Where(n => n.StartsWith("S"));    /// to get names with length > 4 and starting with S

            //var query = names.Where(x => x.Length > 4).Select(n=> n.Substring(0,3));   /// to get names with length > 4 and only first 3 characters

            //var query = names.Where(x => x.Length > 4).Select(n => n.Substring(0, 3)).OrderBy(n=>n);     /// to get names with length > 4 and only first 3 characters and order them alphabetically

            //var query = names.Where(x => x.Length > 4).Select(n => n.Substring(0, 3)).OrderByDescending(n => n);    /// to get names with length > 4 and only first 3 characters and order them in descending order

            //var query = names.Where(x => x.Length > 4).Select(n => n).OrderBy(n => n).ThenBy(n=> n.Length);   /// to get names with length > 4 and order them alphabetically and then by length


            /// We can also define the query in a multiple lines
            //var query = names.Where(x => x.Length > 4);
            //query = query.Select(n => n);
            //query = query.OrderBy(n => n).ThenBy(n => n.Length);

            var query = names.Where(x => x.Length > 4);

            query = query.Select(n => n);

            if (myValue == true)
            {
                query = query.Select(n => n.Substring(0, 4));
                query = query.OrderByDescending(n => n).ThenBy(n => n.Length);
            }
            else
            {
                query = query.OrderBy(n => n).ThenBy(n => n.Length);
            }

            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        
        
        }

    }
}