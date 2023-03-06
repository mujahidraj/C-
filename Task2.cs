using System;

namespace program
{
    public class student {

        public string name;
        public int id;
        public float algorithm_cgpa;
        public float oop2_cgpa;
        public float datastructure_cgpa;
        public student() { }

        public string Name {
            get { return name; }
            set { this.name = value; }
        }
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public float Algorithm {
            get { return algorithm_cgpa; }
            set { this.algorithm_cgpa = value; }
        }

        public float Oop2
        {
            get { return oop2_cgpa; }
            set { this.oop2_cgpa = value; }
        }
        public float Datastructure
        {
            get { return datastructure_cgpa; }
            set { this.datastructure_cgpa = value; }
        }

        void showdetails() {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID   : " + id);
            Console.WriteLine("CGPA : " + algorithm_cgpa);
            Console.WriteLine("CGPA : " + oop2_cgpa);
            Console.WriteLine("CGPA : " + datastructure_cgpa);

        }

        static void Main()
        {

            Console.WriteLine("Enter the Algorithm CGPA :");
            float A = Single.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cgpa :");
            float cgpa = Single.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cgpa :");
            float cgpa = Single.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the id :");
            int id = Int32.Parse(Console.ReadLine());

            student s = new student();
            s.Id = id;
            s.Name = name;
            s.cgpa = cgpa;
            s.showdetails();


        }
    }
    public class GPA : student
    {
        static void calculate() {
                
        
        }






    }