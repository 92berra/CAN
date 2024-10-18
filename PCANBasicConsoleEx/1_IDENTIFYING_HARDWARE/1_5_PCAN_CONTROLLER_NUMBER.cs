using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    public class PCAN_CONTROLLER_NUMBER
    {
        public void controllerNumber(ushort[] channelsToCheck)
        {

            uint controllerNumber;
            ushort canChannel2 = PCANBasic.PCAN_NONEBUS;
            for (int i = 0; i < 4; i++)
            {
                if (PCANBasic.GetValue(channelsToCheck[i], TPCANParameter.PCAN_CONTROLLER_NUMBER, out controllerNumber,
               sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
                {
                    if (controllerNumber == 1)
                    {
                        canChannel2 = channelsToCheck[i];
                        break;
                    }
                }
            }
            if (canChannel2 != PCANBasic.PCAN_NONEBUS)
            {
                Console.WriteLine("Second USB CAN-controller found (handle 0x{0:X}). Starting to work . . .",
               canChannel2);
            }
            else
                Console.WriteLine("Error! Second USB CAN-controller was not found. Terminating . . .");
        }
    }
}
