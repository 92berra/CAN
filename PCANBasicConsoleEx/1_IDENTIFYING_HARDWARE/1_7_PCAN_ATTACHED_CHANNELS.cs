using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    class PCAN_ATTACHED_CHANNELS
    {
        public void attachedChannels(ushort[] channelsToCheck)
        {
            uint channelsCount;
            if (PCANBasic.GetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_ATTACHED_CHANNELS_COUNT, out
            channelsCount, sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
            {
                Console.WriteLine("Total of {0} channels were found:", channelsCount);
                if (channelsCount > 0)
                {
                    TPCANChannelInformation[] channels = new TPCANChannelInformation[channelsCount];
                    if (PCANBasic.GetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_ATTACHED_CHANNELS, channels) ==
                   TPCANStatus.PCAN_ERROR_OK)
                    {
                        for (int i = 0; i < channelsCount; i++)
                        {
                            Console.WriteLine("{0}) ---------------------------\n", i + 1);
                            Console.WriteLine(" Name: {0}", channels[i].device_name);
                            Console.WriteLine(" Handle: 0x{0:X}", channels[i].channel_handle);
                            Console.WriteLine("Controller: {0}", channels[i].controller_number);
                            Console.WriteLine(" Condition: {0}", channels[i].channel_condition);
                            Console.WriteLine(" . . . . .");
                        }
                    }
                }
            }
        }
    }
}
