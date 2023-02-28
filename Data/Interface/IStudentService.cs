using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IStudentService
    {
        IQueryable<Student> GetStudents();
        Student GetStudents(long id);
        int InsertStudents(Student user);
        void UpdateStudents(Student user);
        void DeleteStudents(Student user);
    }
}
