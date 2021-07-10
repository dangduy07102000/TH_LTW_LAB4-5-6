using LAB04_DANGNGUYENHOAIDUY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB04_DANGNGUYENHOAIDUY.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}