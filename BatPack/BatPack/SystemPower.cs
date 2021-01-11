using System;
using System.Runtime.InteropServices;

namespace BatPack
{
    class SystemPower
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern Boolean GetSystemPowerStatus(out SystemPowerStatus s);
        public enum ACStatus : byte
        {
            Offline = 0,
            Online = 1
        }
        public enum BatFlags : byte
        {
            Full = 1,
            Drained = 2,
            Danger = 4,
            Charging = 8,
            NoSystemBattery = 128
        }
        public struct SystemPowerStatus
        {
            public ACStatus LineStatus;
            public BatFlags flgBattery;
            public Byte BatteryLifePercent;
            public Byte Reserved1;
            public Int32 BatteryLifeTime;
            public Int32 BatteryFullLifeTime;
        }

    }
}
