using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.DAL
{
    public interface IStudentsDal
    {
        public IEnumerable<Student> GetStudents();
    }
}
