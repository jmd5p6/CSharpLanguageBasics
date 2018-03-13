using System;

namespace CSharpLanguageBasics
{
    class Constants
    {
        public const Byte sample1 = 0x3A;
        public Byte sample2;
        public int heartRate;
        public double deposits;
        public float mass;
        public double distance;
        public const float acceleration = 9.800F;
        public bool lost;
        public bool expensive;
        public int choice;
        public const char integral = '\u222B';
        public const string greeting = "Hello";
        public string name;
        public float force;

        public Constants()
        {
            sample2 = 58;
            heartRate = 85;
            deposits = 135002796;
            mass = (float)14.6;
            distance = 139.763001;
            lost = true;
            expensive = true;
            choice = 2;
            name = "Karen";
            force = mass * acceleration;
        }



        public void stringCompare()
        {
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }
        }

        public void heartRateCheck()
        {
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }
        }

        public void depositCheck()
        {
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
        }

        public void printForce()
        {
            Console.WriteLine($"force = {force}");
        }

        public void printDistance()
        {
            Console.WriteLine($"{distance} is the distance");
        }

        public void lostCheck()
        {
            if (lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost && !expensive)
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }
        }

        public void choiceCheck()
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
        }

        public void printIntegral()
        {
            Console.WriteLine(integral);
        }

        public void forLoop()
        {
            for (int i = 5; i <= 10; i++)
                Console.WriteLine($"i = {i}");
        }

        public void ageLoop()
        {
            var age = 0;

            while (age < 6)
            {
                Console.WriteLine($"age = {age}");
                age++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var constants = new Constants();

            constants.stringCompare();
            constants.heartRateCheck();
            constants.depositCheck();
            constants.printForce();
            constants.printDistance();
            constants.lostCheck();
            constants.choiceCheck();
            constants.printIntegral();
            constants.forLoop();
            constants.ageLoop();
        }
    }
}
