using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// A static class is similar to a class that is both abstract and sealed. 
/// The difference between a static class and a non-static class is that a static class cannot be instantiated or inherited and that all of the members of the class are static in nature
/// </summary>
namespace DataInputsRPATraining
{
    static class InputData
    {
        //China
        public static string ChinaProduct { get; set; }
        
        public static int ChinaQuantity { get; set; }
        public static double ChinaUnitPrice { get; set; }
        public static double ChinaCostCentre { get; set; }

        //Japan
        public static string JapanProduct { get; set; }
        public static int JapanQuantity { get; set; }
        public static double JapanUnitPrice { get; set; }
        public static double JapanCostCentre { get; set; }

        //USA
        public static string USAProduct { get; set; }
        public static int USAQuantity { get; set; }
        public static double USAUnitPrice { get; set; }
        public static double USACostCentre { get; set; }
    }
}
