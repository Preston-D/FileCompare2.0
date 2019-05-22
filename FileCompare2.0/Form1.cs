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
                outputError("Files Search Complete");
            }
        }
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            progressBarCompare.Maximum = allStudents.studentLength();
            if (radioButtonSlow.Checked)
            {
                _level = DiffEngineLevel.SlowPerfect;
            }
            else if (radioButtonMedium.Checked)
            {
                _level = DiffEngineLevel.Medium;
            }
            else
            {
                _level = DiffEngineLevel.FastImperfect;
            }
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
                labelCompare.Text = (i+1).ToString();

            }
            populateComparisonDisplay();
            this.Cursor = Cursors.Default;
            outputError("Comparisons Complete");
            buttonCompare.Enabled = false;
        }
        private void buttonCompareRefresh_Click(object sender, EventArgs e)
        {
            populateComparisonDisplay();
        }
        private void buttonOpenDiffForm_Click(object sender, EventArgs e)
        {
            string selectedComparison = listBoxComparisons.SelectedItem.ToString();
            outputError(selectedComparison + "opened new result form");
            string[] selectedComparisonArr = selectedComparison.Split('-');
            Student s1 = allStudents.getStudent(selectedComparisonArr[0]);
            Student s2 = allStudents.getStudent(selectedComparisonArr[1]);
            string file = selectedComparisonArr[2];

            Comparison comp = allComparisons.getComparison(file, s1, s2);

            outputError(comp.File1);
            DiffList_TextFile sLF = null;
            DiffList_TextFile dLF = null;
            try
            {
                sLF = new DiffList_TextFile(comp.File1);
                dLF = new DiffList_TextFile(comp.File2);
            }
            catch
            {
                outputError("Error with files while opening diff form");
            }
            Results dlg = new Results(sLF, dLF, comp.diffReport, comp.diffTime);
            dlg.ShowDialog();
            dlg.Dispose();
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

        private void populateComparisonDisplay()
        {
            listBoxComparisons.Items.Clear();
            numericUpDownComparisons.Maximum = allComparisons.length();
            bool html = checkBoxCompHTML.Checked;
            bool css = checkBoxCompCSS.Checked;
            bool etc = checkBoxCompETC.Checked;
            bool showAll = checkBoxCompShowAll.Checked;
            bool showX = checkBoxShowX.Checked;
            decimal top = numericUpDownComparisons.Value;

            float comparisonAverage = 0;
            float largestComparison = 0;

            for (int i = 0; i < allComparisons.length(); i++)
            {
                Comparison cur = allComparisons.getComparison(i);
                string name1 = cur.Student1.Name;
                string name2 = cur.Student2.Name;
                string file1 = System.IO.Path.GetFileName(cur.File1);
                string file2 = System.IO.Path.GetFileName(cur.File1);
                string lcs = cur.diffReport.ToArray().Length.ToString();
                string output = name1 + "-" + name2 + "-" + file1 + "-" + lcs;
                bool isHtml = System.IO.Path.GetExtension(file1).Equals(".html");
                bool isCss = System.IO.Path.GetExtension(file1).Equals(".css");
                if (showAll || (css && isCss) || (html && isHtml))
                {
                    listBoxComparisons.Items.Add(output);
                }
                comparisonAverage += cur.diffReport.ToArray().Length;
                if(cur.diffReport.ToArray().Length > largestComparison)
                {
                    largestComparison = cur.diffReport.ToArray().Length;
                }
            } 
            comparisonAverage = comparisonAverage / allComparisons.length();

            if (showX)
            {
                Queue<Comparison> TopQueue = new Queue<Comparison>();
                float high = largestComparison;
                float comparisonLen;
                for (int i = 0; i < allComparisons.length(); i++)
                {
                    Comparison cur = allComparisons.getComparison(i);
                    comparisonLen = cur.diffReport.ToArray().Length;
                    if (comparisonLen <= high)
                    {
                        high = comparisonLen;
                        TopQueue.Enqueue(cur);
                        if(TopQueue.Count > top)
                        {
                            TopQueue.Dequeue();
                        }
                    }

                }

                while(TopQueue.Count > 0)
                {
                    Comparison cur = TopQueue.Dequeue();
                    string name1 = cur.Student1.Name;
                    string name2 = cur.Student2.Name;
                    string file1 = System.IO.Path.GetFileName(cur.File1);
                    string file2 = System.IO.Path.GetFileName(cur.File1);
                    string lcs = cur.diffReport.ToArray().Length.ToString();
                    string output = name1 + "-" + name2 + "-" + file1 + "-" + lcs;
                    listBoxComparisons.Items.Insert(0, output);
                }
            }
        }


    }
}
