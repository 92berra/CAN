using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

using PCANBasicConsoleEx._1_IDENTIFYING_HARDWARE;
using PCANBasicConsoleEx._2_INFORMATIONAL_PARAMETERS;
//using PCANBasicConsoleEx._3_SPECIAL_BEHAVIORS;
//using PCANBasicConsoleEx._4_CONTROLLING_THE_DATA_FLOW;
//using PCANBasicConsoleEx._5_LOGGING_PARAMETERS;
//using PCANBasicConsoleEx._6_TRACING_PARAMETERS;
//using PCANBasicConsoleEx._7_ELECTRONIC_CIRCUITS_PARAMETER;

namespace PCANBasicConsoleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] channelsToCheck =
            {
                PCANBasic.PCAN_USBBUS1,
                PCANBasic.PCAN_USBBUS2,
                PCANBasic.PCAN_USBBUS3,
                PCANBasic.PCAN_USBBUS4
            };

            Console.WriteLine("Select one of below.");
            Console.WriteLine("Menu");
            Console.WriteLine("1. IDENTIFYING HARDWARE \n" + 
                              "2. INFORMATIONAL PARAMETERS \n" +
                              "3. SPECIAL BEHAVIORS \n" +
                              "4. CONTROLLING THE DATA FLOW \n" +
                              "5. LOGGING PARAMETERS \n" +
                              "6. TRACING PARAMETERS \n" +
                              "7. ELECTRONIC CIRCUITS PARAMETERS \n" +
                              "0. Exit");

            string inputMenu = Console.ReadLine();

            switch (inputMenu)
            {
                case "1":
                    var ex1 = new IDENTIFYING_HARDWARE();
                    ex1.identifyHardware(channelsToCheck);
                    break;

                case "2":
                    var ex2 = new INFORMATIONAL_PARAMETERS();
                    ex2.informationalParameters(channelsToCheck);
                    break;

                default:
                    Console.WriteLine("Invalid option. Exiting . . .");
                    break;
            }
        }
    }
}
