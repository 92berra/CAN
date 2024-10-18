using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    public class PCAN_CHANNEL_CONDITION
    {
        public void channelCondition(ushort[] channelsToCheck)
        {
            uint condition;

            for (int i = 0; i < channelsToCheck.Length; i++)
            {
                if (PCANBasic.GetValue(channelsToCheck[i],
                                       TPCANParameter.PCAN_CHANNEL_CONDITION,
                                       out condition, sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
                {
                    if ((condition & PCANBasic.PCAN_CHANNEL_AVAILABLE) == PCANBasic.PCAN_CHANNEL_AVAILABLE)
                    {
                        Console.WriteLine("The channel-handle 0x{0:X} is AVAILABLE.", channelsToCheck[i]);
                    }
                    else
                    {
                        Console.WriteLine("The channel-handle 0x{0:X} is NOT AVAILABLE.", channelsToCheck[i]);
                    }
                }
                else
                {
                    Console.WriteLine($"Failed to get condition for channel-handle 0x{channelsToCheck[i]:X}.");
                }
            }
        }
    }
}
