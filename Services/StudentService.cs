using api_studentManagement_dotnet.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace api_studentManagement_dotnet.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;

        public StudentService(IStudentStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _students = database.GetCollection<Student>(settings.StudentCollectionName);
        }
        public Student Create(Student student)
        {
            student.Id = "";
            _students.InsertOne(student);
            return student;
        }

        public List<Student> Get()
        {
           return _students.Find(student => true).ToList();
        }

        public Student Get(string id)
        {
           return _students.Find(student => student.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
             _students.DeleteOne(student => student.Id == id);
        }

        public void Update(string id, Student student)
        {
            _students.ReplaceOne(student => student.Id == id, student);
        }
    }
}
