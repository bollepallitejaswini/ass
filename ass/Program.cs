using System.Collections.Generic;
using System;

namespace ConsoleApp6
{
    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int marks { get; set; }
        public int maths { get; set; }
        public int social { get; set; }




    }
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student()
            {
                id = 101,
                name = "yamini",
                gender = "female",
                maths = 60,
                social = 70,

                marks = 130,





            };
            student std1 = new student()
            {
                id = 102,
                name = "teja",
                gender = "female",
                maths = 50,
                social = 72,
                marks = 122,




            };
            student std2 = new student()
            {
                id = 103,
                name = "ram",
                gender = "male",
                maths = 100,
                social = 100,
                marks = 200,
            };
            student std3 = new student()
            {
                id = 103,
                name = "chaitu",
                gender = "male",
                maths = 100,
                social = 100,
                marks = 200,
            };
            student std4 = new student()
            {
                id = 103,
                name = "raju",
                gender = "male",
                maths = 100,
                social = 90,
                marks = 190,
            };
            List<student> lisstd = new List<student>();
            List<student> lisstd1 = new List<student>();
            List<student> lisstd2 = new List<student>();
            List<student> lisstd3 = new List<student>();
            List<student> lisstd4 = new List<student>();

            lisstd.Add(std);
            lisstd1.Add(std1);
            lisstd2.Add(std2);
            lisstd3.Add(std3);
            lisstd4.Add(std4);
            if (lisstd.Contains(std))
            {
                Console.WriteLine("std is exist in the list");
            }
            else
            {


                Console.WriteLine("std does not exist in the list");
            }
            if (lisstd.Exists(x => x.name.StartsWith("d")))
            {


                Console.WriteLine("item is there whose starting from d");


            }
            else
            {


                Console.WriteLine("item is not  there whose starting from d");




            }


            student s = lisstd.Find(student => student.name == "deepti");
            Console.WriteLine("find the student record id={0},name={1}," +
                    "gender={2},marks={3}", s.id, s.name, s.gender, s.marks);


            List<student> filteremp = lisstd.FindAll(student => student.gender == "male");


            foreach (student em in filteremp)
            {
                Console.WriteLine("find the student record id={0},name={1}," +
                    "gender={2},marks={3}", std.id, std.name, std.gender, std.marks);
            }
            //employee empd = lisemp[0];
            //Console.WriteLine("retrieve first employee record id={0},name={1}," +
            //    "gender={2},salary={3}", empd.id, empd.name, empd.gender, empd.salary);

        }
    }
}
