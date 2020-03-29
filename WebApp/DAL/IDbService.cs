using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.DAL
{
    public interface IDbService
    {
        public IEnumerable<Models.Student> GetStudents();
    }
}
