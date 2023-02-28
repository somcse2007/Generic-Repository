using Core.Model;
using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    
    public class StudentService : IStudentService
    {
        private IRepository<Student> studentRepository;

       
        public StudentService(IRepository<Student> studentRepository)
        {
            this.studentRepository = studentRepository;
            
        }

        public IQueryable<Student> GetStudents()
        {
            return studentRepository.Table;  
        }   
        
        Student IStudentService.GetStudents(long id)
        {
            return studentRepository.GetById(id);
        }

        public int InsertStudents(Student user)
        {
            try
            {
                return studentRepository.Insert(user);
            }
            catch
            {
                throw ;
            }
        }

        public void UpdateStudents(Student user)
        {
            studentRepository.Update(user); 
        }

        public void DeleteStudents(Student user)
        {
            studentRepository.Delete(user);
        }
    }
}
