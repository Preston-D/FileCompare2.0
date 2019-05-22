using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare2._0
{
    public class Student
    {
        //const int MAX_FILE_ARRAY_SIZE = 20;
        private ArrayList htmlFiles = new ArrayList();
        private ArrayList cssFiles = new ArrayList();
        private ArrayList etcFiles = new ArrayList();
        //private string[] htmlFiles = new string[MAX_FILE_ARRAY_SIZE];
        //private string[] cssFiles = new string[MAX_FILE_ARRAY_SIZE];
        //private string[] etcFiles = new string[MAX_FILE_ARRAY_SIZE];


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
            string[] htmlFilesarr = (string[])htmlFiles.ToArray(typeof(string));
            string[] cssFilesarr = (string[])cssFiles.ToArray(typeof(string));
            string[] etcFilesarr = (string[])etcFiles.ToArray(typeof(string));
            switch (location)
            {
                case "html":
                    return htmlFilesarr[index];
                case "css":
                    return cssFilesarr[index];
                case "etc":
                    return etcFilesarr[index];
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

        private void addToArray(string file, ArrayList arr)
        {
            arr.Add(file);
        }
        private int arrayLength(ArrayList arr)
        {
            return arr.Count;
        }
    }
}
