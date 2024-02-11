using ConsoleApp1.DataAccess.Concretes;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business;

public class CourseManager
{
    
    public List<Course> GetAll() 
    {
        //business rules
        CourseDal courseDal = new CourseDal();
        return courseDal.GetAll();
       
    }
}
