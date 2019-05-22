using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare2._0
{
    public class Students
    {
        public Students() { }

        public static ArrayList AllStudents = new ArrayList();
        //public static Student[] AllStudents = new Student[10];
        public static int currentIndex = 0;

        public void addStudent(Student s)
        {
            AllStudents.Add(s);
        }

        public void deleteStudent(Student s)
        {
            //TODO
        }

        public Student getStudent(int index)
        {
            try
            {
                return (Student)AllStudents[index];
            }
            catch
            {
                Console.WriteLine("{0} is not a valid index for students.", index);
                return null;
            }
        }

        public Student getStudent(Student s)
        {
            for (int i = 0; i < AllStudents.Count; i++)
            {
                if (AllStudents[i] == s)
                {
                    return (Student)AllStudents[i];
                }
            }
            return null;
        }

        public Student getStudent(string name)
        {
            for (int i = 0; i < AllStudents.Count; i++)
            {
                Student s = (Student)AllStudents[i];
                if (s.Name == name)
                {
                    return s;
                }
            }
            return null;
        }

        public int studentLength()
        {
            return AllStudents.Count;
        }

        public int getIndex(Student s)
        {
            for (int i = 0; i < AllStudents.Count; i++)
            {
                if ((Student)AllStudents[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
