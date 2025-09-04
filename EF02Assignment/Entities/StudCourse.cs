using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02Assignment.Entities
{
    internal class StudCourse
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public double Grade { get; set; }
    }
}
