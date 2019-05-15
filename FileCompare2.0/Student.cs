using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare2._0
{
    public class Student
    {
        const int MAX_FILE_ARRAY_SIZE = 20;
        private string[] htmlFiles = new string[MAX_FILE_ARRAY_SIZE];
        private string[] cssFiles = new string[MAX_FILE_ARRAY_SIZE];
        private string[] etcFiles = new string[MAX_FILE_ARRAY_SIZE];

        public Student() { }

        public Student(string newName)
        {
            Name = newName;
        }
        public string Name { get; set; }

        public void addFile(string file, string location)
        {
            switch (location)
            {
                case "html":
                    addToArray(file, htmlFiles);
                    break;
                case "css":
                    addToArray(file, cssFiles);
                    break;
                case "etc":
                    addToArray(file, etcFiles);
                    break;
            }
        }

        public string getFile(int index, string location)
        {
            switch (location)
            {
                case "html":
                    return htmlFiles[index];
                case "css":
                    return cssFiles[index];
                case "etc":
                    return etcFiles[index];
            }
            return null;
        }

        public int fileArrayLength(string location)
        {
            switch (location)
            {
                case "html":
                    return arrayLength(htmlFiles);
                case "css":
                    return arrayLength(cssFiles);
                case "etc":
                    return arrayLength(etcFiles);
            }
            return -1;

        }

        private void addToArray(string file, string[] arr)
        {
            int i = 0;
            while (arr[i] != null)
            {
                i++;
            }
            arr[i] = file;
        }
        private int arrayLength(string[] arr)
        {
            int index = 0;
            while (arr[index] != null)
            {
                index++;
            }
            return index;
        }
    }
}
