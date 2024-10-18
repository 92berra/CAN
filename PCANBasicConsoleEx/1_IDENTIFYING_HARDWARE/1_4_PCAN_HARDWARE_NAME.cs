using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;
using TPCANHandle = System.UInt16;

namespace PCANBasicConsoleEx
{
    public class PCAN_HARDWARE_NAME
    {
        public void hardwareName(ushort[] channelsToCheck)
        {
            StringBuilder hardwareName = new StringBuilder(PCANBasic.MAX_LENGTH_HARDWARE_NAME);
            TPCANHandle debugBus = PCANBasic.PCAN_NONEBUS;
            for (int i = 0; i < 3; i++)
            {
                if (PCANBasic.GetValue(channelsToCheck[i], TPCANParameter.PCAN_HARDWARE_NAME, hardwareName,
               PCANBasic.MAX_LENGTH_HARDWARE_NAME) == TPCANStatus.PCAN_ERROR_OK)
                {
                    if (hardwareName.ToString().Equals("PCAN-USB"))
                    {
                        debugBus = channelsToCheck[i];
                        break;
                    }
                }
            }
            if (debugBus != PCANBasic.PCAN_NONEBUS)
            {
                Console.WriteLine("Single PCAN-USB for debugging (0x{0:X}) found. Starting to work . . .", debugBus);
                // Do work . . .
            }
            else
                Console.WriteLine("Error! Single PCAN-USB Channel was not found. Terminating . . .");
        }
    }
}
