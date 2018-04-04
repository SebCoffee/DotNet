using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 liens vers le tutoriel : 

    https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
     
     */

namespace DotNet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            SchoolContext db = new SchoolContext();
            Console.WriteLine("Context ok");
            foreach (Student s in db.Students)
            {
                Console.WriteLine(s.LastName);
            }

            Console.Read();
        }
    }
}
