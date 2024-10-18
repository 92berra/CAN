using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx._1_IDENTIFYING_HARDWARE
{
    public class IDENTIFYING_HARDWARE
    {
        public void identifyHardware(ushort[] channelsToCheck)
        {
            Console.WriteLine("Sub Menu \n" +
                              "1. PCAN_CHANNEL_CONDITION \n" +
                              "2. PCAN_CHANNEL_IDENTIFYING \n" +
                              "3. PCAN_DEVICE_ID \n" +
                              "4. PCAN_HARDWARE_NAME \n" +
                              "5. PCAN_CONTROLLER_NUMBER \n" +
                              "6. PCAN_IP_ADDRESS \n" +
                              "7. PCAN_ATTACHED_CHANNELS \n" +
                              "8. PCAN_DEVICE_PART_NUMBER \n" +
                              "0. Move Forward");

            string inputSubMenu = Console.ReadLine();

            switch (inputSubMenu)
            {
                case "1":
                    var ex1_1 = new PCAN_CHANNEL_CONDITION();
                    ex1_1.channelCondition(channelsToCheck);
                    break;

                case "2":
                    var ex1_2 = new PCAN_CHANNEL_IDENTIFYING();
                    ex1_2.channelIdentifying(channelsToCheck);
                    break;

                case "3":
                    var ex1_3 = new PCAN_DEVICE_ID();
                    ex1_3.deviceID(channelsToCheck);
                    break;

                case "4":
                    var ex1_4 = new PCAN_HARDWARE_NAME();
                    ex1_4.hardwareName(channelsToCheck);
                    break;

                case "5":
                    var ex1_5 = new PCAN_IP_ADDRESS();
                    ex1_5.ipAddress(channelsToCheck);
                    break;

                case "6":
                    var ex1_6 = new PCAN_IP_ADDRESS();
                    ex1_6.ipAddress(channelsToCheck);
                    break;

                case "7":
                    var ex1_7 = new PCAN_ATTACHED_CHANNELS();
                    ex1_7.attachedChannels(channelsToCheck);
                    break;

                case "8":
                    var ex1_8 = new PCAN_DEVICE_PART_NUMBER();
                    ex1_8.devicePartNumber(channelsToCheck);
                    break;

                default:
                    Console.WriteLine("Invalid option. Exiting . . .");
                    break;
            }
        }
    }
}
