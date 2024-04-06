using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9DatabaseConnection
{
    internal class SQLiteManager
    {
        // Class used to manage/access the SQLite database
        private SQLiteConnection database;
        public SQLiteManager() 
        {
            // Creates a connection using the pre-specifed path in the Constants class
            database = new SQLiteConnection(Constants.DatabasePath);
            // Creates a Courses table
            database.CreateTable<Course>();
        }

        // Add a course to the course table
        public void AddCourse(Course course)
        {
            database.Insert(course);
        }

        // Get all courses and add them to a list, then display their details in the console
        public void DisplayAllCourses()
        {
            List<Course> allCourses = database.Table<Course>().ToList();

            foreach (Course course in allCourses)
            {
                Console.WriteLine(course);
            } 
        }

        // Find a Course object/row by its Id value 
        public Course GetCourseById(int id)
        {
            return database.Table<Course>().Where(c => c.CourseId == id).FirstOrDefault();
        }

        // Change the columns/attributes of a specified object in the database
        public void UpdateCourse(Course course)
        {
            database.Update(course);
        }

        // Remove a row from the database entirely
        public void DeleteCourse(int id) 
        {
            database.Delete<Course>(id);
        }


    }
}
