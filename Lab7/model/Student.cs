﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    public abstract class Student : IApplicant
    {
        private string name;
        private string faculty;
        private int course;
        private Department studentDepartment;

        public enum Department { Extramural, FullTime };

        protected Student()
        {
        }

        protected Student(string name, string faculty, int course, Department studentDepartment)
        {
            Name = name;
            Faculty = faculty;
            Course = course;
            StudentDepartment = studentDepartment;
        }

        public string Name { get => name; set => name = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public int Course { get => course; set => course = value; }
        private Department StudentDepartment { get => studentDepartment; set => studentDepartment = value; }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   Name == student.Name &&
                   Faculty == student.Faculty &&
                   Course == student.Course &&
                   StudentDepartment == student.StudentDepartment;
        }


        public override int GetHashCode() => HashCode.Combine(Name, Faculty, Course, StudentDepartment);

        public override string ToString() => "Name = " + Name + ", Faculty = " + Faculty + ", Course = " + Course + ", Department" + StudentDepartment;

        public void ShowInformation() => Console.WriteLine("Student: { " + this.ToString() + " }");
    }
}
