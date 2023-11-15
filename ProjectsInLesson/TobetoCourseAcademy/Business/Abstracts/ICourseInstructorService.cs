using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseInstructorService
    {
        void Add(CourseInstructor instructor);
        void Delete(CourseInstructor instructor);
        void Update(CourseInstructor instructor);

        List<CourseInstructor> GetAll();
    }
}
