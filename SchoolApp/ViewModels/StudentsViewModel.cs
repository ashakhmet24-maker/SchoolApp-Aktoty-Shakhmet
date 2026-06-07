using System.Collections.ObjectModel;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel
{
    public ObservableCollection<Student> Students { get; } = new();

    public string NewName { get; set; } = "";

    public StudentsViewModel()
    {
        Students.Add(new Student { Name = "Aida", Gpa = 3.85 });
        Students.Add(new Student { Name = "Bekzat", Gpa = 3.20 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName)) return;

        Students.Add(new Student
        {
            Name = NewName,
            Gpa = 3.0
        });

        NewName = "";
    }
}