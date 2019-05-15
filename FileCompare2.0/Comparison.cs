using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare2._0
{
    public class Comparison
    {

        public Comparison() { }

        public Comparison(string file1, string file2, Student student1, Student student2, int longestCommonSubsequence, double time, System.Collections.ArrayList report)
        {
            File1 = file1;
            File2 = file2;
            Student1 = student1;
            Student2 = student2;
            Lcs = longestCommonSubsequence;
            diffTime = time;
            diffReport = report;
        }
        public string File1 { get; }
        public string File2 { get; }
        public Student Student1 { get; }
        public Student Student2 { get; }
        public int Lcs { get; }
        public double diffTime { get; }
        public System.Collections.ArrayList diffReport { get; }
    }

    public class Comparisons
    {
        public Comparisons() { }

        public static Comparison[] AllComparisons = new Comparison[100];
        public static int currentIndex = 0;

        public void addComparison(Comparison s)
        {
            AllComparisons[currentIndex] = s;
            currentIndex++;
            if (currentIndex > AllComparisons.Length)
            {
                //TODO increase array size
            }
        }

        public void deleteComparison(Comparison s)
        {
            //TODO
        }

        public Comparison getComparison(int index)
        {
            try
            {
                return AllComparisons[index];
            }
            catch
            {
                Console.WriteLine("{0} is not a valid index for students.", index);
                return null;
            }
        }

        public Comparison getComparison(Comparison s)
        {
            for (int i = 0; i < AllComparisons.Length; i++)
            {
                if (AllComparisons[i] == s)
                {
                    return AllComparisons[i];
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
            int index = 0;
            while (AllComparisons[index] != null)
            {
                index++;
            }
            return index;
        }

        public int getIndex(Comparison s)
        {
            for (int i = 0; i < AllComparisons.Length; i++)
            {
                if (AllComparisons[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
