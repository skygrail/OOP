using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Student
    {
        public int age { get; private set; }
        public int course { get; private set; }
        public string faculty { get; set; }
        public string name { get; private set; }
        public Student(int age_arg = 0, int course_arg = 0,
            string faculty_arg = "FIT", string name_arg = "Boo") =>
            (age, course, faculty, name) =
            (age_arg, course_arg, faculty_arg, name_arg);

        public void Scale(int x = 1, int y = 1)
        {
            if ((x < 17) || (y < 2))
            {
                throw new ArgumentException("One argument is below zero");
            }
            else
            {
                age = age * x;
                course = course * y;
            }
        }

        public override string ToString()
        {
            return $"Студент: {name}; Возраст: {age}Факультет: {faculty}; Курс: {course}";
        }
    }
}
