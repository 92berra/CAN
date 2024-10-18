using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    public class PCAN_CHANNEL_IDENTIFYING
    {
        public void channelIdentifying(ushort[] channelsToCheck)
        {
            uint activate;

            for (int i = 0; i < channelsToCheck.Length; i++)
            {
                activate = PCANBasic.PCAN_PARAMETER_ON;

                if (PCANBasic.SetValue(channelsToCheck[i],
                                       TPCANParameter.PCAN_CHANNEL_IDENTIFYING,
                                       ref activate,
                                       sizeof(uint)) == TPCANStatus.PCAN_ERROR_OK)
                {
                    Console.WriteLine("The channel with handle 0x{0:X} is now BLINKING.", channelsToCheck[i]);
                    Console.WriteLine("Press any Key to continue . . .");
                    Console.ReadKey();

                    activate = PCANBasic.PCAN_PARAMETER_OFF;
                    PCANBasic.SetValue(channelsToCheck[i],
                                       TPCANParameter.PCAN_CHANNEL_IDENTIFYING,
                                       ref activate,
                                       sizeof(uint));
                }
            }
        }
    }

}
