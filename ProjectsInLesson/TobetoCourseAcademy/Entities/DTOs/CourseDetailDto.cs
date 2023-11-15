using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CourseDetailDto : IDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public string CategoryName { get; set; }
        public decimal CoursePrice { get; set; }
        public string CourseImage { get; set; }
        public string CourseDescription { get; set; }
    }
}
