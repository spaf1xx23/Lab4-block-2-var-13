using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_block_2_var_13
{
    public struct Student
    {
            public string surName;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] lines = lineWithAllData.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            surName = lines[0];
            firstName = lines[1];
            patronymic = lines[2];
            sex = lines[3][0];
            dateOfBirth = lines[4];
            mathematicsMark = lines[5][0];
            physicsMark = lines[6][0];
            informaticsMark = lines[7][0];
            scholarship = Convert.ToInt32(lines[8]);
            if (lines[5][0] == '-')
            {
                mathematicsMark = '2';
            }
            else
            {
                mathematicsMark = (char)lines[5][0];
            }
            if (lines[6][0] == '-')
            {
                physicsMark = '2';
            }
            else
            {
                physicsMark = (char)lines[6][0];
            }
            if (lines[7][0] == '-')
            {
                informaticsMark = '2';
            }
            else
            {
                informaticsMark = (char)lines[7][0];
            }
        }
            public bool GetExellentStudent()
            {
            return informaticsMark == '5';
            }
            public int Average()
            {
            int sum = Convert.ToInt32(mathematicsMark.ToString()) + Convert.ToInt32(physicsMark.ToString()) + Convert.ToInt32(informaticsMark.ToString());
            int average = sum / 3;
            return average;
            }
        public void PrintInfo()
        {
                Console.WriteLine(surName + "\t\t" + Average());
                
        }
    }
}
