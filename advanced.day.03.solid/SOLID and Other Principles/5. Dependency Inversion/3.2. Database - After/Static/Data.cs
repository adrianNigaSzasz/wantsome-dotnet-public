namespace DependencyInversionDatabaseStaticAfter
{
    using System.Collections.Generic;

    public static class Data
    {
        private static AbstractData data;

        public static void setData(AbstractData data)
        {
            Data.data = data;
        }
        public static IEnumerable<int> CourseIds()
        {
            // return course ids
            if (Data.data != null)
            {
                return Data.data.CourseIds();
            }
            return null;
        }

        public static IEnumerable<string> CourseNames()
        {
            // return course ids
            if (Data.data != null)
            {
                return Data.data.CourseNames();
            }
            return null;
            // return course names
        }

        public static IEnumerable<string> Search(string substring)
        {
            if (Data.data != null)
            {
                return Data.data.Search(substring);
            }
            // return found results
            return null;
        }

        public static string GetCourseById(int id)
        {
            if (Data.data != null)
            {
                return Data.data.GetCourseById(id);
            }
            // return course by id
            return null;
        }
    }
}
