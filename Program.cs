using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightCoupingDemo1
{
    
    
        //Tight Coupling

        //creating Different types of Engine classes

        public class PetrolEngine
        {
            public void Start()
            {
                Console.WriteLine( "Petrol engine started...");
            }
        }
        public class DieselEngine
        {
            public void Start()
            {
                Console.WriteLine("Diesel engine started...");
            }
        }
        public class ElectricEngine
        {
            public void Start()
            {
                Console.WriteLine("Electric engine started...");
            }
        }
        //creating Car class
        public class Car
        {
            // PetrolEngine engine; //object is declared
            //DieselEngine engine;
            ElectricEngine engine;
            public Car()
            {
                engine = new ElectricEngine(); //creating engine class object
                                               //engine=new DieselEngine();
                                               //engine=new PetrolEngine();
            }
            public void Start()
            {
                engine.Start();
                Console.WriteLine("Car started....");
            }
        }
        internal class Program
        { 


            static void Main(string[] args)
            {
                //creating Car object
                Car myCar = new Car();
                myCar.Start(); //starting car
                Console.ReadKey();

            }

        
        }
}
