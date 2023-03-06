using System;

namespace ConsoleApplication5
{
    class CarSpeed
    {
        public float acceleration;
        public string engine_number;
        public bool start;
        public int time; CarSpeed()
        {
        }
        void StartCar()
        {
            if (start == true)
            {
                Console.WriteLine("Car Started Succesfully");
                this.velocity(acceleration, time);
            }
            else
            {
                Console.WriteLine("No velocity Available");
            }
        }
        void StopCar()
        {
            if (start == false) { Console.WriteLine("Car Stoped Succesfully"); }
        }
        void setaccelaration(float acceleration)
        {
            this.acceleration = acceleration;
        }
        float getaccelaration()
        {
            return acceleration;
        }
        void setengine_number(string engine_number)
        { this.engine_number = engine_number; }
        string getengine_number()
        {
            return engine_number;
        }
        void setstart(bool start)
        { this.start = start; }
        int getstart()
        {
            return time;
        }
        void settime(int time)
        { this.time = time; }
        int gettime()
        {
            return time;
        }
        void velocity(float acceleration, int time)
        {
            Console.WriteLine("The velocity is : "+acceleration * time); 
        }
        void showdetails()
        {
            this.StartCar();
            Console.WriteLine("Acceleration Is : "+acceleration);
            Console.WriteLine("Engine Number of the car is : "+engine_number);
            Console.WriteLine("Time Since Started : "+time);
            
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Enter the Accelaration :");
                float acceleration = Single.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Engine_number :");
                string engine_number = Console.ReadLine();

                Console.WriteLine("Is car started :");
                bool start = bool.Parse(Console.ReadLine());

                Console.WriteLine("Enter the time :");
                int time = Int32.Parse(Console.ReadLine());


                CarSpeed s = new CarSpeed();
                s.setaccelaration(acceleration);
                s.setengine_number(engine_number);
                s.settime(time);
                s.setstart(start);
                s.showdetails();
            }
        }
    }
}