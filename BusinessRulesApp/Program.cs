using System;
using System.Collections.Generic;

/*
 * Developer Anas Mudassar
 * Version 1.0
 * Business Rules Engine
 */
namespace BusinessRulesApp
{
    class Program
    {
        static void Main()
        {
            Menu();
            Console.WriteLine("Enter Your Choice: ");
            string input = Console.ReadLine();
            Choice(input);
        }

        //function for Main Menu 
        private static void Menu()
        {
            Console.WriteLine("Select the Product: ");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Other Physical Product");
            Console.WriteLine("3. Membership");
            Console.WriteLine("4. Upgrade Membership");
            Console.WriteLine("5. Video");
        }

        public static void Choice(string input)
        {
            try
            {
                // Products pro;
                if (input.Equals("1") || input.Equals("Book"))
                {
                    Book b = new Book();
                    Console.WriteLine(b);
                    
                }
                else if (input.Equals("2") || input.Equals("Other Physical Product") || input.Equals("Other"))
                {
                    new OtherPhysicalProduct("Other");
                    // return pro;
                }
                else
                {
                    Console.WriteLine("Wrong Selection!");
                    // return pro;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
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
            Console.WriteLine("Packing Slip for Shipping Generated");
        }

        //Function for Royality Slip
        public void RoyaltySlip()
        {
            Console.WriteLine("Duplicate Packing Slip for Royalty Department Generated");
        }

        //function for Commission Slip
        public void CommissionSlip()
        {
            Console.WriteLine("Commission Payment to the agent Generated.");
        }

        

        
    }

    //Book Class
    class Book : PhysicalProducts
    {
        //Funtion for Book
        public Book( )
        {
            //PhysicalProduct.Add("Book");
            base.ShipSlip();
            base.RoyaltySlip();
            base.CommissionSlip();
        }
    }

    //Other Physical Product Class
    class OtherPhysicalProduct : PhysicalProducts
    {
        //Funtion for Any Other Physical Product
        public OtherPhysicalProduct(string Other)
        {
            PhysicalProduct.Add(Other);
            base.ShipSlip();
            base.CommissionSlip();
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

    

}
