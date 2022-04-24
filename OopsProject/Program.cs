using System;
using System.Collections.Generic;
using System.IO;

namespace OopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string oneclassfile = @"C:\oopsproject\OneClass.txt";
            string studentfile = @"c:\oopsproject\Student.txt";
            string subjectfile = @"c:\oopsproject\Subject.txt";
            List<OneClass> listoneclass = new List<OneClass>();
            List<Student> liststudent = new List<Student>();
            List<Subject> listsubject = new List<Subject>();

            string[] arroneclass = File.ReadAllLines(oneclassfile);
            foreach(string line in arroneclass)
            {
                string[] l= line.Split(",");
                OneClass oneClass = new OneClass();
                oneClass.Grade = l[0];
                oneClass.Section = l[1];
                listoneclass.Add(oneClass);
                
            }

            string[] arrstudent = File.ReadAllLines(studentfile);
            foreach(string line in arrstudent)
            {
                string[] l = line.Split(",");
                Student student = new Student();
                student.Name = l[0];
                student.Grade = l[1];
                student.Section = l[2];
                liststudent.Add(student);
            }

            string[] arrsubject = File.ReadAllLines(subjectfile);
            foreach(string line in arrsubject)
            {
                string[] l = line.Split(",");
                Subject subject = new Subject();
                subject.Name = l[0];
                subject.Code = l[1];
                subject.Teacher = l[2];
                subject.Grade = l[3];
                subject.Section = l[4];
                listsubject.Add(subject);
            }

            foreach(OneClass c in listoneclass)
            {
                Console.WriteLine($"\nGrade : {c.Grade}\t Section : {c.Section}");

                Console.WriteLine("\nStudents :");
                foreach (Student s in liststudent)
                {
                    if((s.Grade == c.Grade) && (s.Section == c.Section))
                    {
                        Console.WriteLine($" {s.Name}");
                    }
                }

                Console.WriteLine("\nSubjects : ");
                foreach (Subject v in listsubject)
                {
                    if ((v.Grade == c.Grade) && (v.Section == c.Section))
                    {
                        Console.WriteLine($" {v.Name}\t - {v.Teacher}");
                        
                    }
                }
            }
            Console.ReadKey();
        }

    }
}
