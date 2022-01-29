using System;

namespace api_studentManagement_dotnet.Models
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {
        public string StudentCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
