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
            // Let's create an test object from the Device class with default constructor (0 parameters):
            //Device device1 = new Device();
            //Console.WriteLine(device1.Identity);

            // Let's create another device with identity parameter:
            //Device device2 = new Device("Toinen laite");
            //Console.WriteLine(device2.Identity);

            // Setting device2 warranty to 60 months:
            //device2.Warranty = 60;

            //Console.WriteLine("Takuutiedoksi päivitetty: " + device2.Warranty);

            // Let's create one more device with all parameters:
            //Device device3 = new Device("Kolmas kone", "8.2.2024", 150.00d, 36);

            //Console.WriteLine(device3.Identity);
            //Console.WriteLine(device3.Price);
            //Console.WriteLine(device3.DateBought);
            //Console.WriteLine(device3.Warranty);


            // CREATING OBJECTS AND TESTING METHODS:
            // -------------------------------------

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tietokone 1:n hankintatiedot: ");
            Console.WriteLine("--------------------------------");
            // Creating new Computer named >computer1>. Inherits properties and methods from Device class.
            Computer computer1 = new Computer();
            // setting value to Processor:
            computer1.ProcessorType = "Intel I7";
            // setting value to RAM:
            computer1.AmountRAM = 16;
            computer1.DateBought = "15.2.2024";
            computer1.Price = 250.00d;
            computer1.Warranty = 12;
            {
                computer1.ShowPurchaseInfo();
            }


            //Console.WriteLine("New computer name is: " + computer1.Identity + " and there is " + computer1.ProcessorType + " with " + computer1.AmountRAM + "GB RAM " );
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tietokone 2:n hankintatiedot: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            // Creating new named computer with another contructor.
            Computer computer2 = new Computer("Antin uusi supertietokone");
            computer2.ProcessorType = "Inter Core i7 vPro";
            computer2.AmountRAM = 32;
            computer2.ShowPurchaseInfo();
            computer2.ShowBasicTechInfo();

            // Testing tablet
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tablet 1:n hankintatiedot: ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            Tablet tabletti1 = new Tablet("Antin mielikuvitustabletti");
            tabletti1.OperationSystem = "IOS";
            tabletti1.DateBought = "6.9.1696";
            tabletti1.StylusEnablet = true;
            tabletti1.ShowPurchaseInfo();
            tabletti1.TabletInfo();

            //// keeps the window open untill >Enter> is pressed.
            Console.ReadLine();
        }
    }
}