namespace Lab9DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Database contains 5 courses already
            SQLiteManager sqliteDatabase = new SQLiteManager();

            // A new course to add to the list of courses
            Course newCourse = new()
            {
                CourseId = 1006,
                Name = "UX/UI Design",
                Credit = 3
            };

            // Creating
            Console.WriteLine("Adding UX/UI Course");
            sqliteDatabase.AddCourse(newCourse);
            Console.WriteLine();

            // Reading
            Console.WriteLine("Displaying all courses in the databse");
            sqliteDatabase.DisplayAllCourses();
            Console.WriteLine();

            // Updating
            Console.WriteLine("Updating Database Course");
            Course modifiedCourse = sqliteDatabase.GetCourseById(1003);
            modifiedCourse.Name = "Intro to Database";
            modifiedCourse.Credit = 4;
            sqliteDatabase.UpdateCourse(modifiedCourse);
            Console.WriteLine();

            // Deleting
            Console.WriteLine("Deleting the UX/UI Course");
            sqliteDatabase.DeleteCourse(1006);
            Console.WriteLine();

            // Final changes displayed
            Console.WriteLine("Displaying modified database courses");
            sqliteDatabase.DisplayAllCourses();
            Console.WriteLine();

            // Resetting the changed values to re-run the program multiple times
            Course resetCourse = sqliteDatabase.GetCourseById(1003);
            resetCourse.Name = "Database";
            resetCourse.Credit = 3;
            sqliteDatabase.UpdateCourse(resetCourse);
        }

    }
}
