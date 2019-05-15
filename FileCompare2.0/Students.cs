using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare2._0
{
    public class Students
    {
        public Students() { }

        public static Student[] AllStudents = new Student[10];
        public static int currentIndex = 0;

        public void addStudent(Student s)
        {
            AllStudents[currentIndex] = s;
            currentIndex++;
            if (currentIndex > AllStudents.Length)
            {
                //TODO increase array size
            }
        }

        public void deleteStudent(Student s)
        {
            //TODO
        }

        public Student getStudent(int index)
        {
            try
            {
                return AllStudents[index];
            }
            catch
            {
                Console.WriteLine("{0} is not a valid index for students.", index);
                return null;
            }
        }

        public Student getStudent(Student s)
        {
            for (int i = 0; i < AllStudents.Length; i++)
            {
                if (AllStudents[i] == s)
                {
                    return AllStudents[i];
                }
            }
            return null;
        }

        public Student getStudent(string name)
        {
            for (int i = 0; i < AllStudents.Length; i++)
            {
                if (AllStudents[i].Name == name)
                {
                    return AllStudents[i];
                }
            }
            return null;
        }

        public int studentLength()
        {
            int index = 0;
            while (AllStudents[index] != null)
            {
                index++;
            }
            return index;
        }

        public int getIndex(Student s)
        {
            for (int i = 0; i < AllStudents.Length; i++)
            {
                if (AllStudents[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
