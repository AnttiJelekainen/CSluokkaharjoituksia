using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri
{
    /* Base class for devices */
    class Device
    {
        // Fields
        // ------
        string identity = "Uusi laite";
        string dateBought = "1.1.2000";
        double price = 0.00d;
        int warranty = 12;

        // Properties
        // ----------

        string processorType;
        public string ProcessorType { get { return processorType; } set { processorType = value; } }


        int amountRAM;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }


        int storageCapacity;
        public int StorageCapacity { get { return storageCapacity; } set { storageCapacity = value; } }

        public string Identity
        {
            get { return identity; }
            set { identity = value; }

        }

        public string DateBought
        {
            get { return dateBought; }
            set { dateBought = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }

        // Constructors
        // ------------

        public Device()
        {

        }
        // A constructor with one argument
        public Device(string identity)
        {
            this.identity = identity;
        }

        // Another constructor with all arguments
        public Device(string identity, string dateBought, double price, int warranty)
        {
            this.identity = identity;
            this.dateBought = dateBought;
            this.price = price;
            this.warranty = warranty;
        }

        // Device(/base) class methods:
        public void ShowPurchaseInfo() 
        {
            Console.WriteLine("Laitteen nimi: " + this.identity);
            Console.WriteLine("Ostopäivä: " + this.dateBought);
            Console.WriteLine("Hinta: " + this.price);
            Console.WriteLine("Takuuaika: " + this.warranty);
        }

        public void ShowBasicTechInfo()
        {
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti:  " + AmountRAM);
            Console.WriteLine("Levytila: " + StorageCapacity);
        }

        // Other methods
        // -------------


    }

    /* Class for Computers | Inherits properties and methods from Device class. */
    class Computer : Device
    {
        // Constructors:
        public Computer() : base() 
            { }

        public Computer(string identity) : base(identity)
        { }

        // Other methods:
        public void ShowInfo() 
        {
            Console.WriteLine("Koneen nimi: " + Identity);
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti:  " +  AmountRAM);
            Console.WriteLine("Levytila: " + StorageCapacity);
        }
    }

    class SmartPhone : Device
    { }

    class Tablet : Device
    {

        // Fields:
        // -------

        string operatingSystem;
        public string OperationSystem { get { return operatingSystem; } set { operatingSystem = value; } }

        bool stylusEnablet = false;
        public bool StylusEnablet { get { return stylusEnablet; } set { stylusEnablet = value; } }

        // Properties:
        // -----------


        // Constructors
        //-------------

        public Tablet() : base()
        { }

        public Tablet(string identity) : base(identity)
        { }

        // Tablet class spesific methods:
        // ------------------------------

        public void TabletInfo()
        {

            Console.WriteLine("Käyttöjärjestelmä: " + OperationSystem);
            Console.WriteLine("Kynätuki: " + stylusEnablet);
        }

        // Other methods
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop that keeps up the main program running:
            while (true)
            {
                Console.WriteLine("Minkä laitteen tiedot tallennetaan? ");
                Console.Write("1.) Computer, 2.) Tablet, 3.) Phone");
                string type = Console.ReadLine();


                // While loop exit:
                Console.WriteLine("Haluatko jatkaa K/e");
                string continueAnswer = Console.ReadLine();
                continueAnswer = continueAnswer.Trim();
                continueAnswer = continueAnswer.ToLower();

                if (continueAnswer == "e")
                {
                    break;
                }

                
            }

            //// keeps the window open untill >Enter> is pressed.
            Console.ReadLine();
        }
    }
}