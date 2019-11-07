using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.creational.AbstractFactoryMethod
{

    class Implementation
    {
        public void GetStudentName()
        {
            Student student = new Student("Talented");
            string name = student.GetName();
        }
    }
    class Student
    {
        public string StudentType { get; set; }
        public Student(string Type)
        {
            this.StudentType = Type;
        }
        
        /// <summary>
        /// Method
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return "Jitesh" + "Srivastava";
        }

        private string GetFName()
        {
            return "Jitesh";
        }
    }


}
