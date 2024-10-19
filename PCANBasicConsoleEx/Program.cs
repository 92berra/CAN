using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx
{
    using TPCANHandle = System.UInt16;
    using TPCANBitrateFD = System.String;
    using TPCANTimestampFD = System.UInt64;

    class Program
    {

        static void Main(string[] args)
        {
            TPCANHandle channel = PCANBasic.PCAN_USBBUS1;
            TPCANBaudrate m_baurdrate = TPCANBaudrate.PCAN_BAUD_500K;

            TPCANStatus stsResult = PCANBasic.Initialize(channel, m_baurdrate);

            Console.WriteLine($"Success to initialize {channel}.");

        }

        private TPCANStatus WriteFrame()
        {
            TPCANMsg CANMsg;

            CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.ID = Convert.ToUInt32("5V Power", 16);
            CANMsg.LEN = Convert.ToByte(8);
            CANMsg.MSGTYPE = TPCANMessageType.PCAN_MESSAGE_EXTENDED;

            for (int i = 0; i < 8; i++)
            {
                // random 
                CANMsg.DATA[i] = Convert.ToByte();
            }

            return PCANBasic.Write(channel, ref CANMsg);
        }
    }
}
