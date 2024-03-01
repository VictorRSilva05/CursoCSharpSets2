using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Entities
{
    internal class Courses
    {
        public int Id { get; set; }

        public Courses(int id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Courses))
            {
                return false;
            }
            Courses other = obj as Courses;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
