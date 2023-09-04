
List<StudentClass> Student = new List<StudentClass>();
Student.Add(new StudentClass(){StudentID=1});

var id = int.Parse(Console.ReadLine() ?? "0");
var stud = from student in Student
    where id == student.StudentID
    select student;

class StudentClass
{
    public int StudentID { get; set; }
}

public class ExampleController : Controller
{
    private static string TargetDirectory = "/example/directory/";

    public void ExtractEntry(IEnumerator<ZipArchiveEntry> entriesEnumerator)
    {
        ZipArchiveEntry entry = entriesEnumerator.Current;
        string destinationPath = Path.Combine(TargetDirectory, entry.FullName);

        entry.ExtractToFile(destinationPath);
    }
}
