using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionDatabaseStaticAfter
{
	public abstract class AbstractData
	{
        abstract public IEnumerable<int> CourseIds();

        abstract public IEnumerable<string> CourseNames();

        abstract public IEnumerable<string> Search(string substring);

        abstract public string GetCourseById(int id);

    }
}
