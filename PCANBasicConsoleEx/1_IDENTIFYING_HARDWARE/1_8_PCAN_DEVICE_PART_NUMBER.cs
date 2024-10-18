using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    class PCAN_DEVICE_PART_NUMBER
    {
        public void devicePartNumber(ushort[] channelsToCheck)
        {
            ushort channelUsed = PCANBasic.PCAN_USBBUS1;
            StringBuilder partNumber = new StringBuilder(100);
            if (PCANBasic.Initialize(channelUsed, TPCANBaudrate.PCAN_BAUD_500K) == TPCANStatus.PCAN_ERROR_OK)
                if (PCANBasic.GetValue(channelUsed, TPCANParameter.PCAN_DEVICE_PART_NUMBER, partNumber, 100) ==
               TPCANStatus.PCAN_ERROR_OK)
                    Console.WriteLine("Part number: {0}", partNumber);
                else
                    Console.WriteLine("Error! Could not retrieve the part number of the device.");
        }
    }
}
