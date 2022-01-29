namespace api_studentManagement_dotnet.Models
{
    public interface IStudentStoreDatabaseSettings
    {
        string StudentCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
