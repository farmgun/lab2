
using System;


namespace cat
{
    
    public class cat
    {
        public enum Gender 
        {
            female,
            male
        };
        
        string name;
        Gender gender;
        double Energy;
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;


        public cat(string name, Gender gender)
        {
            
            this.name = name;
            this.gender = gender;
            Energy = MaxEnergy;
        }
        ~cat()
        {

        }

        public void Output ()
        {
            Console.WriteLine(this.name + " " + this.gender + " Energy = " + this.Energy);
        }

        public void Jump()
        {
            if (this.Energy >= 0.5)
            { 
                this.Energy -= JumpEnergyDrain;
                Console.WriteLine(this.Energy);
            }
            else
            {
                this.Energy = 0;
                Console.WriteLine("Not enough energy to jump!");
            }

        }

        public void Sleep()
        {
            if (this.Energy <= 10)
            { 
                this.Energy += SleepEnergyGain;
                Console.WriteLine(this.Energy);
            }
            else
            {
                this.Energy = 20;
                Console.WriteLine("Energy restored!");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            cat c1 = new cat("barsik",cat.Gender.female);
            c1.Output();
            c1.Sleep();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Output();
            c1.Sleep();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump(); 
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump(); 
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump(); 
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
            c1.Jump();
        }
    }
}
