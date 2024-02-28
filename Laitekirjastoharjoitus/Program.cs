using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

        string processorType = "N/A";
        public string ProcessorType { get { return processorType; } set { processorType = value; } }


        int amountRAM = 0;
        public int AmountRAM { get { return amountRAM; } set { amountRAM = value; } }


        int storageCapacity = 0;
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
            Console.WriteLine("Hinta: " + this.price + " euroa");
            Console.WriteLine("Takuuaika: " + this.warranty + "kk");
        }

        public void ShowBasicTechInfo()
        {
            Console.WriteLine("Prosessori: " + ProcessorType);
            Console.WriteLine("Keskusmuisti:  " + AmountRAM);
            Console.WriteLine("Levytila: " + StorageCapacity);
            Console.WriteLine();
        }

        // This method shows the last date of warranty:
        public void WarrantyDate()
        {
            // Calculating the end of warranty, notice ISO-standarded dates: year-month-day
            DateTime startDate = DateTime.ParseExact(this.DateBought, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            // Changing datetime-string to datetime-clock format:
            DateTime endDate = startDate.AddMonths(this.Warranty);

            // Changing datetime to ISO-standard format:
            string isoDate = endDate.ToString("s");
            Console.WriteLine("Takuu päättyy " + isoDate);

        }
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

        // Fields and Properties:
        // ----------------------

        string operatingSystem; // Fields
        public string OperationSystem { get { return operatingSystem; } set { operatingSystem = value; } } // Properties -> starts with uppercase

        bool stylusEnablet = false;
        public bool StylusEnablet { get { return stylusEnablet; } set { stylusEnablet = value; } }



        // Constructors
        // -------------

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
            // Creating VECTORS and counter to items/elements:
            Computer[] computers = new Computer[10];
            Tablet[] tablets = new Tablet[10];
            SmartPhone[] smartphones = new SmartPhone[10];
            int numberOfComputers = 0;
            int numberOfTables = 0;
            int numberOfSmartPhones = 0;

            // alternative creating STACK for devices
            Stack<Computer> computerStack = new Stack<Computer>();



            // While loop that keeps up the main program running:
            while (true)
            {
                Console.WriteLine("Minkä laitteen tiedot tallennetaan? ");
                Console.Write("1.) Tietokone 2.) Tabletti 3.) Älypuhelin : ");
                string type = Console.ReadLine();

                // Creating Switch-Case structure:
                switch(type)
                {

                    case "1":
                        Console.Write("Nimi: ");
                        string computerName = Console.ReadLine();
                        Computer computer = new Computer(computerName);

                        Console.Write("Ostopäivä muodossa vvvv-kk-pp: ");
                        computer.DateBought = Console.ReadLine();

                        try
                        {

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Virheellinene ostopäivä: " + ex.Message);
                            break;
                        }

                            Console.Write("Hinta: ");
                        string price = Console.ReadLine();

                        try
                        {
                            computer.Price = double.Parse(price);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Virheellinen hintatieto: " + ex.Message);
                            break;
                        }

                        Console.WriteLine("Takuun kesto kuukausina: ");
                        string warranty = Console.ReadLine();

                        try
                        {
                            computer.Warranty = int.Parse(warranty);
                            

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Virheellinen takuutieto, ilmoita kokonaislukuna: " + ex.Message);
                            break;
                        }

                        Console.Write("Prosessorin tyyppi: ");
                        computer.ProcessorType = Console.ReadLine();
                        Console.Write("Keskumuistin määrä (GB): ");
                        string amountRam = Console.ReadLine();

                        try
                        {
                            computer.AmountRAM = int.Parse(amountRam);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Virheellinen muistin määrä, vain kokonaisluvut sallittu: " + ex.Message);
                            break;
                        }

                        Console.Write("Tallennuskapasiteetti (GB): ");
                        string storageCapacity = Console.ReadLine();

                        try
                        {
                            computer.StorageCapacity = int.Parse(storageCapacity);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Virheellinen tallennustilan koko, vain kokonaisluvut sallittu: " + ex.Message);
                            break;
                        }

                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine();


                        // Show the info of elements by using method:
                        computer.ShowPurchaseInfo();

                        try
                        {
                            computer.WarrantyDate();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ostopäivä virheellinen: " + ex.Message);
                            break;
                        }

                        Console.WriteLine();
                        computer.ShowBasicTechInfo();

                        // Adding computer into VECTOR:
                        computers[numberOfComputers] = computer;
                        Console.WriteLine("Vektorin indeksi on nyt " + numberOfComputers);
                        numberOfComputers++;
                        Console.WriteLine($"Nyt syötettiin {numberOfComputers}. kone");

                        // alternative add computers into STACK

                        computerStack.Push(computer);


                        break;

                    case "2":
                        Console.Write("Nimi: ");
                        string tabletName = Console.ReadLine();
                        Tablet tablet = new Tablet();
                        break;

                    case "3":
                        Console.Write("Nimi: ");
                        string smartphoneName = Console.ReadLine();
                        SmartPhone smartphone = new SmartPhone();
                        break;

                    default:
                        Console.WriteLine("Virheellinen valinta - anna pelkkä numero");
                        break;
                }


                Console.WriteLine();
                // While loop exit:
                Console.WriteLine("Haluatko jatkaa K/e");
                string continueAnswer = Console.ReadLine();
                continueAnswer = continueAnswer.Trim();
                continueAnswer = continueAnswer.ToLower();

                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("");

                if (continueAnswer == "e")
                {
                    // summary before closing program:
                    Console.WriteLine("Tietokonevektorissa on " + computers.Length + " alkiota");
                    Console.WriteLine($"Pinossa on nyt {computerStack.Count} tietokonetta");

                    break;
                }

                
            }

            //// keeps the window open untill >Enter> is pressed.
            Console.ReadLine();
        }
    }
}