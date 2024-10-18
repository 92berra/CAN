using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx._2_INFORMATIONAL_PARAMETERS
{
    public class INFORMATIONAL_PARAMETERS
    {
        public void informationalParameters(ushort[] channelsToCheck)
        {
            Console.WriteLine("Sub Menu \n" + 
                "1. PCAN_API_VERSION \n" + 
                "2. PCAN_CHANNEL_VERSION \n" + 
                "3. PCAN_CHANNEL_FEATURES \n" + 
                "4. PCAN_BITRATE_INFO \n" + 
                "5. PCAN_BITRATE_INFO_FD \n" + 
                "6. PCAN_BUSSPEED_NOMINAL \n" + 
                "7. PCAN_BUSSPEED_DATA \n" + 
                "8. PCAN_LAN_SERVICE_STATUS \n" + 
                "9. PCAN_FIRMWARE_VERSION \n" + 
                "10. PCAN_ATTATCHED_CHANNELS_COUNT \n" +
                "11. PCAN_LAN_CHANNEL_DIRECTION \n" +
                "0. Move Forward");

            string inputSubMenu = Console.ReadLine();

            switch (inputSubMenu)
            {
                case "1":
                    var ex2_1 = new PCAN_API_VERSION();
                    ex2_1.apiVersion(channelsToCheck);
                    break;

                default:
                    Console.WriteLine("Invalid option. Exiting . . .");
                    break;
            }
        }
    }
    
}
