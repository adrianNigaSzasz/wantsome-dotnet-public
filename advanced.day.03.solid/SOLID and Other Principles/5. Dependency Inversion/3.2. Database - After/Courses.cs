namespace DependencyInversionDatabaseAfter
{
    public class Courses
    {
        private IData _data;

        public Courses(IData data)
        {
            this._data = data;
        }
        public void PrintAll()
        {

            var courses = this._data.CourseNames();

            // print courses
        }

        public void PrintIds()
        {
            var courses = this._data.CourseIds();

            // print courses
        }

        public void PrintById(int id)
        {

            var courses = this._data.GetCourseById(id);

            // print courses
        }

        public void Search(string substring)
        {
            var courses = this._data.Search(substring);

            // print courses
        }
    }
}
