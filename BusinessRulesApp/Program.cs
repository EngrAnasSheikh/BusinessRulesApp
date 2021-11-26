using System;
using System.Collections.Generic;

/*
 * Developer Anas Mudassar
 * Version 1.0
 * Business Rules Engine
 */
namespace BusinessRulesApp
{
    //Class for Products
    public abstract class Products
    {
        //List Array for Physical Products
        public List<string> PhysicalProduct { get; set; }

        //List Array for Non Physical Products
        public List<string> NonPhysicalProduct { get; set; }

        //List Array for All Instructions
        public List<string> Instructions { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
