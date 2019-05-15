using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using DifferenceEngine;

namespace FileCompare2._0
{
    public partial class Form1 : Form
    {
        public Students allStudents = new Students();
        public Comparisons allComparisons = new Comparisons();
        private DiffEngineLevel _level = DiffEngineLevel.SlowPerfect;

        public Form1()
        {
            InitializeComponent();
        }

        // Form Event Functions
        private void buttonGetFiles_Click(object sender, EventArgs e)
        {
            if (textBoxFilePath.Text == "")
            {
                outputError("The Filepath was not defined or empty.");
            }
            else
            {
                string filePath = textBoxFilePath.Text;
                recursiveFileSearch(filePath);
                for (int i = 0; i < allStudents.studentLength(); i++)
                {
                    Student s = allStudents.getStudent(i);
                    listBoxDisplayStudents.Items.Add(s.Name);
                }
                buttonGetFiles.Enabled = false;
            }
        }
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            progressBarCompare.Maximum = allStudents.studentLength();
            for (int i = 0; i < allStudents.studentLength(); i++)
            {
                Student student1 = allStudents.getStudent(i);
                for (int j = 0; j < allStudents.studentLength(); j++)
                {
                    Student student2 = allStudents.getStudent(j);
                    if (student1 != student2)
                    {
                        CompareStudentFileType(student1, student2, "html");
                        CompareStudentFileType(student1, student2, "css");
                    }
                }
                progressBarCompare.Value++;
                labelCompare.Text = i.ToString();

            }
            for (int i = 0; i < allComparisons.length(); i++)
            {
                string name1 = allComparisons.getComparison(i).Student1.Name;
                string name2 = allComparisons.getComparison(i).Student2.Name;
                string file1 = System.IO.Path.GetFileName(allComparisons.getComparison(i).File1);
                string file2 = System.IO.Path.GetFileName(allComparisons.getComparison(i).File1);
                string lcs = allComparisons.getComparison(i).diffReport.ToArray().Length.ToString();
                string output = name1 + "'s " + file1 + " compared to " + name2 + "'s " + file2 + " resulted in an lcs of: " + lcs;
                listBoxComparisons.Items.Add(output);
            }
            this.Cursor = Cursors.Default;
        }

        //File Search Functions
        private void recursiveFileSearch(string path)
        {
            if (File.Exists(path))
            {
                // This path is a file
                recursiveFileSearch(path);
            }
            else if (Directory.Exists(path))
            {
                // This path is a directory
                ProcessDirectory(path, -1);
            }
            else
            {
                outputError("{0} is not a valid file or directory." + path);
            }
        }
        public void ProcessDirectory(string targetDirectory, int passedStudentIndex)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName, passedStudentIndex);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                string name = System.IO.Path.GetFileName(subdirectory);
                if (passedStudentIndex == -1)
                {
                    Student student = new Student(name);
                    allStudents.addStudent(student);
                    ProcessDirectory(subdirectory, allStudents.getIndex(student));
                }
                else
                {
                    ProcessDirectory(subdirectory, passedStudentIndex);
                }

            }

        }
        public void ProcessFile(string path, int studentIndex)
        {
            Student student = allStudents.getStudent(studentIndex);
            string extension = Path.GetExtension(path);
            switch (extension)
            {
                case ".html":
                    student.addFile(path, "html");
                    break;
                case ".css":
                    student.addFile(path, "css");
                    break;
                default:
                    student.addFile(path, "etc");
                    break;
            }


        }

        //File Compare Functions
        private void CompareStudentFileType(Student student1, Student student2, string fileType)
        {
            for (int i = 0; i < student1.fileArrayLength(fileType); i++)
            {
                string fileFromStudent1 = System.IO.Path.GetFileName(student1.getFile(i, fileType));
                for (int j = 0; j < student1.fileArrayLength(fileType); j++)
                {
                    string fileFromStudent2 = System.IO.Path.GetFileName(student2.getFile(j, fileType));
                    if (fileFromStudent1.Equals(fileFromStudent2))
                    {

                        //int lcs = LcsFileComparison(student1.getFile(i, fileType), student2.getFile(j, fileType));
                        int lcs = 0;
                        DiffEngine de = new DiffEngine();
                        DiffList_TextFile sLF = null;
                        DiffList_TextFile dLF = null;
                        try
                        {
                            sLF = new DiffList_TextFile(student1.getFile(i, fileType));
                            dLF = new DiffList_TextFile(student2.getFile(j, fileType));
                        }
                        catch
                        {
                            string err = "file error with " + System.IO.Path.GetFileName(student1.getFile(i, fileType)) + " and " + System.IO.Path.GetFileName(student2.getFile(j, fileType));
                            MessageBox.Show(err, "error");
                        }
                        try
                        {
                            double time = de.ProcessDiff(sLF, dLF, _level);
                            ArrayList report = de.DiffReport();
                            Comparison c = new Comparison(
                                student1.getFile(i, fileType),
                                student2.getFile(j, fileType),
                                student1,
                                student2,
                                lcs,
                                time,
                                report
                            );
                            allComparisons.addComparison(c);
                        }
                        catch
                        {
                            string err = "comparison error with " + System.IO.Path.GetFileName(student1.getFile(i, fileType)) + " and " + System.IO.Path.GetFileName(student2.getFile(j, fileType));
                            MessageBox.Show(err, "error");
                        }

                    }
                }
            }
        }


        //Utility Functions
        private void outputError(string err)
        {
            richTextBoxOutput.Text += "\n" + err;
        }

    }
}
