using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9DatabaseConnection
{
    internal class Constants
    {
        // Using Constants class to hold the value for the path of this directory, and the database file name.
        public const string DatabaseFilename = "StudentCourses.db3";
        public static string DatabasePath => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, DatabaseFilename);
        
        Constants() { }
    }
}
