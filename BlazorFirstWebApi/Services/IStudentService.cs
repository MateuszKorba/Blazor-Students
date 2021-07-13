using BlazorFirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFirstWebApi.Services
{
    public interface IStudentService
    {
        public List<Student> listOfStudents { get; set; }
        public void SetList();
    }
}
