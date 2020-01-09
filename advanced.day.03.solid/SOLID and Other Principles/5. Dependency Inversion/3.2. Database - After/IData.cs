using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDatabaseAfter
{
	public interface IData
	{
        IEnumerable<int> CourseIds();



        IEnumerable<string> CourseNames();

        IEnumerable<string> Search(string substring);

        string GetCourseById(int id);
        
    }
}
