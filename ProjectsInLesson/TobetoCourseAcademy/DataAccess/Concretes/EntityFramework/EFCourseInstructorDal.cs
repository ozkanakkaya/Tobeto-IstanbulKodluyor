﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EFCourseInstructorDal : EFEntityRepositoryBase<CourseInstructor, TobetoCourseAcademyContext>, ICourseInstructorDal
    {
        public EFCourseInstructorDal(TobetoCourseAcademyContext context) : base(context)
        {
        }
    }
}
