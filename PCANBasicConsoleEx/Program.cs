using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    using TPCANHandle = System.UInt16;

    class Program
    {
        static void Main(string[] args)
        {
            TPCANHandle channel = PCANBasic.PCAN_USBBUS1;
            StringBuilder hardwareName = new StringBuilder(PCANBasic.MAX_LENGTH_HARDWARE_NAME);

            uint controllerNumber;
            TPCANHandle debugBus = PCANBasic.PCAN_NONEBUS;
            ushort canChannel2 = PCANBasic.PCAN_NONEBUS;

            if (PCANBasic.GetValue(channel, 
                                    TPCANParameter.PCAN_HARDWARE_NAME, 
                                    hardwareName,
                                    PCANBasic.MAX_LENGTH_HARDWARE_NAME) 
                                    == TPCANStatus.PCAN_ERROR_OK)
            {
                if (hardwareName.ToString().Equals("PCAN-USB"))
                {
                    debugBus = channel;
                }
            }

            if (PCANBasic.GetValue(channel, 
                                    TPCANParameter.PCAN_CONTROLLER_NUMBER, 
                                    out controllerNumber, 
                                    sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
            {
                if (controllerNumber == 1)
                {
                    canChannel2 = channel;
                }
            }


            if (debugBus != PCANBasic.PCAN_NONEBUS)
            {
                Console.WriteLine("Single PCAN-USB for debugging (0x{0:X}) found. Starting to work . . .", debugBus);
            }
            else
                Console.WriteLine("Error! Single PCAN-USB Channel was not found. Terminating . . .");


            if (PCANBasic.GetValue(channel, 
                                    TPCANParameter.PCAN_CONTROLLER_NUMBER, 
                                    out controllerNumber, 
                                    sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
            {
                if (controllerNumber == 1)
                {
                    debugBus = channel;
                }
            }

            if (canChannel2 != PCANBasic.PCAN_NONEBUS)
            {
                Console.WriteLine("CAN Controller found (handle 0x{0:X}). Starting to work . . .", canChannel2);
            }
            else
                Console.WriteLine("Error! CAN Controller was not found. Terminating . . .");
        }
    }
}
