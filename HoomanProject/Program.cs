using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoomanProject
{
    class Hooman
    {
        // Define properties of Hooma ie. fields
        string name = "Essi Esimerkki";
        int age = 30;
        string gender = "Emäntä";

        Hooman()
        {

        }

        // constructor with one argument
        Hooman(string name)
        {
            this.name = name;
        }

        // constructor with two arguments

        Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // constructor with 3 arguments
        Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
