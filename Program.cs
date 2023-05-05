using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
  //Name : Moizuddin Mohammad Mujahid Rashid
  //Id: 22-46398-1
namespace sportingclub
{

    public class Player
    {

        private string id;
        private string name;
        private int salary;
        private DateTime joining_date;

        public Player(string id, string name, int salary, DateTime joining_date)
        {

            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joining_date = joining_date;

        }
        public string Id
        {
            set { this.id = value; }
            get { return id; }

        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }

        }
        public int Salary
        {
            set { this.salary = value; }
            get { return salary; }

        }
        public DateTime Joining_date
        {
            set { this.joining_date = value; }
            get { return joining_date; }

        }
        public virtual void showdetails()
        {
            Console.WriteLine("Player Id :" + id);
            Console.WriteLine("Player name :" + name);
            Console.WriteLine("Player Salary :" + salary);
            Console.WriteLine("Player JOining_date :" + joining_date);



        }
    }
    public class Cricketer : Player {
        private int totalrun;
        private int totalwicket;
        public Cricketer(string id, string name, int salary, DateTime joining_date, int totalrun, int totalwicket) : base(id, name, salary, joining_date)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.totalrun = totalrun;
            this.totalwicket = totalwicket;
        }
        public int Totalrun {
            set { this.totalrun = value; }
            get { return totalwicket; }


        }
        public int Totalwicket
        {
            set { this.totalwicket = value; }
            get { return totalwicket; }


        }
        public override void showdetails (){

        base.showdetails();
            Console.WriteLine("Total Run :" + totalrun);
            Console.WriteLine("Total Wicket :" + totalwicket);
            Console.WriteLine("-----------------------------");



        }




    }
    public class Footballer : Player
    {
        private int goal;
        private int assist;
        public Footballer(string id, string name, int salary,DateTime joining_date,int goal,int assist) : base(id, name, salary, joining_date)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Joining_date = joining_date;
            this.goal = goal;
            this.assist = assist;

        }
        public int Goal
        {
            set { this.goal = value; }
            get { return goal; }


        }
        public int Assist
        {
            set { this.Assist = value; }
            get { return Assist; }


        }
        public override void showdetails()
        {
            base.showdetails();
            Console.WriteLine("Total goal :" + goal);
            Console.WriteLine("Total Assist :" + assist);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cr = new Cricketer("P-01", "Shakib", 70000, new DateTime(2006_8-12), 6755, 285);
            Footballer ft = new Footballer("P-02", "Jamal", 50000,  new DateTime(2013-6-13), 20, 15);
            cr.showdetails();
            ft.showdetails();
        }
    }

}
