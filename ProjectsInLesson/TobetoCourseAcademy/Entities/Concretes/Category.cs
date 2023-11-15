﻿using Entities.Abstracts;

namespace Entities.Concretes
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }
}