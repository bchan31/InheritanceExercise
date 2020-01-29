using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE -- Create a class Animal
            // DONE --  give this class 4 members that all Animals have in common


            // DONE --  Create a class Bird
            // DONE --  give this class 4 members that are specific to Bird
            // DONE --  Set this class to inherit from your Animal Class

            // DONE --  Create a class Reptile
            // DONE --  give this class 4 members that are specific to Reptile
            // DONE --  Set this class to inherit from your Animal Class




            /* DONE -- Create an object of your Bird class 
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird("Robin");
            bird1.FeatherColor = "black";
            bird1.BeakColor = "yellow";
            bird1.DoMigrate = true;

            Console.WriteLine($"{bird1.Name}s have {bird1.FeatherColor} feathers and a {bird1.BeakColor} beak.");

            /* DONE -- Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var reptile1 = new Reptile("Stony Lizardboy");
            reptile1.EggColor = "brown";
            reptile1.HasSplitTongue = false;
            reptile1.CanSwim = true;

            string SwimBool()
            {
                if(reptile1.CanSwim == true)
                {
                    return "can swim";
                }
                else
                {
                    return "cannot swim";
                }
            }

            string TongueBool()
            {
                if(reptile1.HasSplitTongue == true)
                {
                    return "has a split tongue";
                }
                else
                {
                    return "do not have a split tongue";
                }
            }

            Console.WriteLine($"{reptile1.Name}s {SwimBool()} and {TongueBool()}.");
        }
    }
}
