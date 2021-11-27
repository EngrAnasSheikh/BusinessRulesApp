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

    //Class for Non Physcial Products
    class NonPhysicalProducts : Products
    {
        //function for Memebership Activation
        public void MembershipSlip()
        {
            Instructions.Add("Membership Activated.");
            Console.WriteLine(Instructions[3]);
        }

        //function for Membership Upgrade
        public void UpgradeSlip()
        {
            Instructions.Add("Membership Upgraded.");
            Console.WriteLine(Instructions[4]);
        }

        //function for Email Sent
        public void EmailSlip()
        {
            Instructions.Add("Email Sent to Owner.");
            Console.WriteLine(Instructions[5]);
        }

        //function for First Aid Slip
        public void FirstSlip()
        {
            Instructions.Add("'First Aid' Video has been added.");
            Console.WriteLine(Instructions[6]);
        }

        //function for Membership
        public void Memebership()
        {
            NonPhysicalProduct.Add("Membership");
            MembershipSlip();
            EmailSlip();
        }

        //function for Upgrade Membership
        public void UpgradeMemebership()
        {
            NonPhysicalProduct.Add("Upgrade Membership");
            UpgradeSlip();
            EmailSlip();
        }

        //Function for Video
        public void Video(string vName)
        {
            NonPhysicalProduct.Add(vName);
            if (vName.Equals("learning to ski"))
            {
                FirstSlip();
            }
            else
            {
                Console.WriteLine("You have added a Video");
            }
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
