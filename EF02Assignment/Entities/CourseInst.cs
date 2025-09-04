using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02Assignment.Entities
{
    internal class CourseInst
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }   

        public int Evaluate { get; set; }
    }
}
