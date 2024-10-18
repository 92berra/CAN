using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    public class PCAN_IP_ADDRESS
    {
        public void ipAddress (ushort[] channelsToCheck)
        {
            StringBuilder ipBuffer = new StringBuilder(20);
            ushort lanToWatch = PCANBasic.PCAN_NONEBUS;
            for (int i = 0; i < 3; i++)
            {
                if (PCANBasic.GetValue(channelsToCheck[i], TPCANParameter.PCAN_IP_ADDRESS, ipBuffer, 20) ==
               TPCANStatus.PCAN_ERROR_OK)
                {
                    if (ipBuffer.ToString().CompareTo("10.1.12.214") == 0)
                    {
                        lanToWatch = channelsToCheck[i];
                        break;
                    }
                }
            }
            if (lanToWatch != PCANBasic.PCAN_NONEBUS)
            {
                Console.WriteLine("LAN channel found (handle 0x{0:X}). . .", lanToWatch);
            }
            else
                Console.WriteLine("Error! LAN channel with required IP is not available. Terminating . . .");
        }
    }
}
