using Lab4_block_2_var_13;
using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string inputFilePath = "input.txt";

        List<Student> studentsList = ReadStudentsFromFile(inputFilePath);

        ProcessVariant13(studentsList);
    }

    static List<Student> ReadStudentsFromFile(string filePath)
    {
        List<Student> parsedStudents = new List<Student>();
        string[] fileLines = File.ReadAllLines(filePath);

        foreach (string currentLine in fileLines)
        {
            Student newStudent = new Student(currentLine);
            parsedStudents.Add(newStudent);
        }

        return parsedStudents;
    }

    static void ProcessVariant13(List<Student> allStudents)
    {
        Console.WriteLine("Прізвище студента\tСередній бал");

        foreach (Student currentStudent in allStudents)
        {
            if (currentStudent.GetExellentStudent())
            {
                currentStudent.PrintInfo();
            }
        }
    }
}
