﻿using System;
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
            Console.WriteLine(" ");
            Console.WriteLine("Select the Product: Enter Number or Name");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Other Physical Product");
            Console.WriteLine("3. Membership");
            Console.WriteLine("4. Upgrade Membership");
            Console.WriteLine("5. Video");
            Console.WriteLine("6. Exit");
            Console.WriteLine(" ");
        }

        public static void Choice(string input)
        {
            try
            {
                if (input.Equals("1") || input.Equals("Book") || input.Equals("book")) //Condition For selection of the Book
                {
                    Console.WriteLine("Enter Book Name: ");
                    string BookName = Console.ReadLine();
                    new Book(BookName);
                   Main(); 
                }
                else if (input.Equals("2") || input.Equals("Other Physical Product") || input.Equals("Other")) //Condition For selection of the Other Physical Product
                {
                    Console.WriteLine("Enter a Physical Product: ");
                    string PName = Console.ReadLine();
                    new OtherPhysicalProduct(PName);
                    Main();
                }
                else if (input.Equals("3") || input.Equals("Membership") || input.Equals("membership")) //Condition For selection of the Membership
                {
                    new Membership();
                    Main();
                }
                else if (input.Equals("4") || input.Equals("Upgrade Membership") || input.Equals("Upgrade") || input.Equals("upgrade")) //Condition For selection of the Upgrade Membership
                {
                    new UpgradeMembership();
                    Main();
                }
                else if (input.Equals("5") || input.Equals("Video") || input.Equals("video")) //Condition For selection of the Video
                {
                    Console.WriteLine("Enter Video Name: ");
                    string VideoName = Console.ReadLine();
                    new Video(VideoName);
                    Main();
                }
                else if (input.Equals("6") || input.Equals("Exit") || input.Equals("exit")) //Condition For selection of the Exit
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Wrong Selection! Select Again!");
                    Main();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
   

    //Class for Physical Products
    public abstract class PhysicalProducts
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
        public Book(string book)
        {
            base.ShipSlip();
            base.RoyaltySlip();
            base.CommissionSlip();
        }
    }

    //Other Physical Product Class
    class OtherPhysicalProduct : PhysicalProducts
    {
        //Funtion for Any Other Physical Product
        public OtherPhysicalProduct(string other)
        {
            base.ShipSlip();
            base.CommissionSlip();
        }
    }

    //Class for Non Physcial Products
    public abstract class NonPhysicalProducts
    {
        //function for Memebership Activation
        public void MembershipSlip()
        {
            Console.WriteLine("Membership Activated.");
        }

        //function for Membership Upgrade
        public void UpgradeSlip()
        {
            Console.WriteLine("Membership Upgraded.");
        }

        //function for Email Sent
        public void EmailSlip()
        {
            Console.WriteLine("Email Sent to Owner.");
        }

        //function for First Aid Slip
        public void FirstSlip()
        {
            Console.WriteLine("'First Aid' Video has been added.");
        }
    }

    //Membership Class
    class Membership : NonPhysicalProducts
    {
        //function for Membership
        public Membership()
        {
            base.MembershipSlip();
            base.EmailSlip();
        }
    }

    //Upgrade Memebrship Class
    class UpgradeMembership : NonPhysicalProducts
    {
        //function for Upgrade Membership
        public UpgradeMembership()
        {
            base.UpgradeSlip();
            base.EmailSlip();
        }
    }

    //Video Class
    class Video : NonPhysicalProducts
    {
        //Function for Video
        public Video(string vName)
        {
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
