using api_studentManagement_dotnet.Models;
using System.Collections.Generic;

namespace api_studentManagement_dotnet.Services
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id, Student student);
        void Remove(string id);
    }
}
