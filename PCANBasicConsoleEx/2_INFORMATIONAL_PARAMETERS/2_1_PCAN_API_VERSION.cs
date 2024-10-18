using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace PCANBasicConsoleEx._2_INFORMATIONAL_PARAMETERS
{
    public class PCAN_API_VERSION
    {
        public void apiVersion(ushort[] channelsToCheck)
        {
            StringBuilder apiVersion = new StringBuilder(PCANBasic.MAX_LENGTH_VERSION_STRING);
            if (PCANBasic.GetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_API_VERSION, apiVersion,
            PCANBasic.MAX_LENGTH_VERSION_STRING) == TPCANStatus.PCAN_ERROR_OK)
            {
                Console.WriteLine("The PCAN-Basic version used is: {0}", apiVersion);
            }

        }
    }
}
