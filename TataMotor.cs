using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23
{
    public class TataMotor
    {
        // Static Variables / Fields
        public static string Founder = "Ratan Tata";
        public static string CompanyName = "Tata Corp";
        public static int YearFounded = 2000;

        // Instance Variables/Properties
        public string Color { get; set; }
        public bool IsAutomatic { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        // Non_Static Method
        public void DisplayModelDetails()
        {
            Console.WriteLine($"Model {Model}, Price: {Price}, Color: {Color}");
        }
        
        // Static Method
        public static void DisplayCompanyDetails()
        {
            Console.WriteLine($"Founder: {Founder}, CompanyName: {CompanyName}, Year: {YearFounded}");
        }
    }
}
