using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pepole!");
        }

        class Animal
        {
         //Class:
            // Animal Base Class
            public class Dog : Animal
            {
                 
            }

           public class Cat :Animal
           {
                
           }

            public class Tiger :Animal
            {
                 
            }

            //METHOD:
        public virtual void Sleep()
        {
           Console.WriteLine("Sleeping");
        }

        

      

// PROPERTY:
        public String Name { get; set; }
        public int NumOfLegs { get; set; }
        public int Age { get; set; }


        }
    }
}



 //public void Sleep()
 //           {
 //               Console.WriteLine("Sleep!");
 //               Dog aDog = new Dog();
 //               aDog.Bark();
 //               aDog.Eat();
 //               aDog.Sleep();
 //           }

 //           public virtual void Eat()
 //           {
 //               Console.WriteLine("Eat!");
 //           }

 //           class Dog : Animal
 //           {
 //               public override void Eat()
 //               {
 //                   Console.WriteLine("Dog is Eating");

 //               }
               
 //               public void Bark()
 //               {
 //                   Console.WriteLine("Bark!");