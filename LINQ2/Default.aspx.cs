using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ2
{
    public partial class Default : System.Web.UI.Page
    {
        List<Student> studentList;
        protected void Page_Load(object sender, EventArgs e)
        {
            studentList = new List<Student>()
            {
                new Student{Id = 101, Name = "Anil", Cost = 7000, Course = "Web Design"},
                new Student{Id = 102, Name = "Arshdeep", Cost = 8000, Course = "Computer Science"},
                new Student{Id = 103, Name = "Harman", Cost = 9000, Course = "Networking"},
                new Student{Id = 104, Name = "Bikram", Cost = 10000, Course = "ICT"},
                new Student{Id = 105, Name = "Gagan", Cost = 7000, Course = "Web Design"},
                new Student{Id = 106, Name = "Love", Cost = 15000, Course = "Business"},
                new Student{Id = 107, Name = "Jashan", Cost = 9500, Course = "MBA"},
                new Student{Id = 108, Name = "Jeevan", Cost = 6000, Course = "Hardware Design"}
            };
            var students = from student in studentList
                           where student.Cost<=7000 && student.Course == "Web Design"
                select student;
            GVStudents.DataSource = students;
            GVStudents.DataBind();

        }
    }
}