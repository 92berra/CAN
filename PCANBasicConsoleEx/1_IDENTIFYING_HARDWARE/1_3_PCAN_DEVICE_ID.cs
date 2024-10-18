using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    public class PCAN_DEVICE_ID
    {
        public void deviceID(ushort[] channelsToCheck)
        {
            uint deviceId;
            ushort readChannel, writeChannel;
            readChannel = writeChannel = PCANBasic.PCAN_NONEBUS;

            for (int i = 0; i < 2; i++)
            {
                if (PCANBasic.GetValue(channelsToCheck[i], TPCANParameter.PCAN_DEVICE_ID, out deviceId, sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
                {
                    if (deviceId == 1)
                    {
                        writeChannel = channelsToCheck[i];
                        Console.WriteLine("The channel for writing (handle 0x{0:X}) was found.", channelsToCheck[i]);
                    }
                    if (deviceId == 2)
                    {
                        readChannel = channelsToCheck[i];
                        Console.WriteLine("The channel for reading (handle 0x{0:X}) was found.", channelsToCheck[i]);
                    }
                }
            }
            if ((readChannel != PCANBasic.PCAN_NONEBUS) && (writeChannel != PCANBasic.PCAN_NONEBUS))
            {
                Console.WriteLine("Both channels were found. Starting to work . . .");
            }
            else
                Console.WriteLine("Error! Not all needed channels were found. Terminating . . .");
        }
    }

}
