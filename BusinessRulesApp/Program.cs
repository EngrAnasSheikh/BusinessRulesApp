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

    //Class for Physical Products
    class PhysicalProducts : Products
    {
        //function for shipping packing slip
        public void ShipSlip()
        {
            Instructions.Add("Packing Slip for Shipping Generated");
            Console.WriteLine(Instructions[0]);
        }

        //Function for Royality Slip
        public void RoyaltySlip()
        {
            Instructions.Add("Duplicate Packing Slip for Royalty Department Generated");
            Console.WriteLine(Instructions[1]);
        }

        //function for Commission Slip
        public void CommissionSlip()
        {
            Instructions.Add("Commission Payment to the agent Generated.");
            Console.WriteLine(Instructions[2]);
        }

        //Funtion for Book
        public void Book(string BookName)
        {
            PhysicalProduct.Add(BookName);
            ShipSlip();
            RoyaltySlip();
            CommissionSlip();
        }

        //Funtion for Any Other Physical Product
        public void OtherPhyscialProduct(string Other)
        {
            PhysicalProduct.Add(Other);
            ShipSlip();
            CommissionSlip();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
