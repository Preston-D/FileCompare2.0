using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifferenceEngine;

namespace FileCompare2._0
{
    public class Comparison
    {

        public Comparison() { }

        public Comparison(string file1, string file2, Student student1, Student student2, int longestCommonSubsequence, double time, ArrayList report)
        {
            File1 = file1;
            File2 = file2;
            Student1 = student1;
            Student2 = student2;
            Lcs = longestCommonSubsequence;
            diffTime = time;
            diffReport = report;

            calculateTotalDiffReportLengths();
        }
        public string File1 { get; }
        public string File2 { get; }
        public Student Student1 { get; }
        public Student Student2 { get; }
        public int Lcs { get; }
        public double diffTime { get; }
        public ArrayList diffReport { get; }

        //total length of diffreport changes;
        public int deleteLength { get; set; }
        public int noChangeLength { get; set; }
        public int addDestinationLength { get; set; }
        public int replaceLength { get; set; }

        private void calculateTotalDiffReportLengths()
        {
            deleteLength = 0;
            noChangeLength = 0;
            addDestinationLength = 0;
            replaceLength = 0;

            foreach (DiffResultSpan drs in diffReport)
            {
                switch (drs.Status)
                {
                    case DiffResultSpanStatus.DeleteSource:
                        deleteLength += drs.Length;
                        break;
                    case DiffResultSpanStatus.NoChange:
                        noChangeLength += drs.Length;
                        break;
                    case DiffResultSpanStatus.AddDestination:
                        addDestinationLength += drs.Length;
                        break;
                    case DiffResultSpanStatus.Replace:
                        replaceLength += drs.Length;
                        break;
                }
            }


        }

    }
    /// <summary>
    /// ////////////////////////////////////////////////
    /// </summary>
    public class Comparisons
    {
        public Comparisons() { }

        //public static Comparison[] AllComparisons = new Comparison[100];
        public static ArrayList AllComparisons = new ArrayList();
        public static ArrayList AllComparisonsSortedByNoChangeLength = new ArrayList();
        public static ArrayList AllComparisonsSortedByDeleteSourceLength = new ArrayList();
        public static ArrayList AllComparisonsSortedByAddDestinationLength = new ArrayList();
        public static ArrayList AllComparisonsSortedByReplaceLength = new ArrayList();
        public static int currentIndex = 0;

        public void addComparison(Comparison s)
        {
            AllComparisons.Add(s);
        }

        public void deleteComparison(Comparison s)
        {
            //TODO
        }

        public Comparison getComparison(int index)
        {
            try
            {
                return (Comparison)AllComparisons[index];
            }
            catch
            {
                Console.WriteLine("{0} is not a valid index for comparisons.", index);
                return null;
            }
        }

        public Comparison getComparison(Comparison s)
        {
            for (int i = 0; i < AllComparisons.Count; i++)
            {
                if ((Comparison)AllComparisons[i] == s)
                {
                    return (Comparison)AllComparisons[i];
                }
            }
            return null;
        }

        public Comparison getComparison(string file1, Student s1, Student s2)
        {
            for (int i = 0; i < AllComparisons.Count; i++)
            {
                Comparison c = (Comparison)AllComparisons[i];
                bool isfile1 = (file1.Equals(System.IO.Path.GetFileName(c.File1)));
                bool isS1 = (s1.Equals(c.Student1));
                bool isS2 = (s2.Equals(c.Student2));
                if (isfile1 && isS1 && isS2)
                {
                    return c;
                }
            }
            return null;
        }

        //public Comparison getStudent(string name)
        //{
        //    for (int i = 0; i < AllComparisons.Length; i++)
        //    {
        //        if (AllComparisons[i]. == name)
        //        {
        //            return AllComparisons[i];
        //        }
        //    }
        //    return null;
        //}

        public int length()
        {
            return AllComparisons.Count;
        }

        public int getIndex(Comparison s)
        {
            for (int i = 0; i < AllComparisons.Count; i++)
            {
                if ((Comparison)AllComparisons[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }

        private ArrayList sortedBy(string catagory)
        {
            //TODO!!!!!!!!!!
            return new ArrayList();
        }
    }
}
