using BlazorFirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFirstWebApi.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> listOfStudents { get; set; }
        public bool isInitialized = false;
        public void SetList()
        {
            if (isInitialized == false) {
                listOfStudents = new List<Student>();
                listOfStudents.Add(new Student
                {
                    IdStudent = 1,
                    Avatar = "https://www.w3schools.com/w3css/img_avatar3.png",
                    FirstName = "Mateusz",
                    LastName = "Korba",
                    BirthDate = new DateTime(1999, 02, 26),
                    Studies = "Informatyka"
                });
                listOfStudents.Add(new Student
                {
                    IdStudent = 2,
                    Avatar = "https://www.w3schools.com/w3css/img_avatar3.png",
                    FirstName = "Nina",
                    LastName = "Michalik",
                    BirthDate = new DateTime(1999, 11, 05),
                    Studies = "Informatyka"
                });
                listOfStudents.Add(new Student
                {
                    IdStudent = 3,
                    Avatar = "https://www.w3schools.com/w3css/img_avatar3.png",
                    FirstName = "Filip",
                    LastName = "Jakubowski",
                    BirthDate = new DateTime(2000, 05, 05),
                    Studies = "Informatyka"
                });
                listOfStudents.Add(new Student
                {
                    IdStudent = 4,
                    Avatar = "https://www.w3schools.com/w3css/img_avatar3.png",
                    FirstName = "Kacper",
                    LastName = "Jasiński",
                    BirthDate = new DateTime(1998, 07, 17),
                    Studies = "Informatyka"
                });
                isInitialized = true;
            }
        }
    }
}
