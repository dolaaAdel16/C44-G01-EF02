using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02Assignment.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public string HiringDate { get; set; }

        //public Instructor Instructor { get; set; }  

        //public int? InsId { get; set; } // Foreign Key  


    }
}
