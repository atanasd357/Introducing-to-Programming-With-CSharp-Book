using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    //enumeration
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, LiPo
    }

    public class Battery
    {
        //fields
        private BatteryType type = BatteryType.LiIon;
        private uint hoursTalk = 0;
        private uint idleTime = 0;

        //constructors
        public Battery() :
            this(BatteryType.LiIon)
        { }

        public Battery(BatteryType type) :
            this(type, 0)
        { }

        public Battery(BatteryType type, uint hoursTalk) :
            this(type, hoursTalk, 0)
        { }
        
        public Battery(BatteryType type, uint hoursTalk, uint idleTime)
        {
            this.type = type;
            this.hoursTalk = hoursTalk;
            this.idleTime = idleTime;
        }

        //properties
        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public uint IdleTime
        {
            get { return this.idleTime; }
            set { this.idleTime = value; }
        }

        //method
        public string PrintBatteryInfo()
        {
            StringBuilder bInfo = new StringBuilder();
            bInfo.AppendLine("Battery model: " + this.type);
            bInfo.AppendLine("Hours talk: " + this.hoursTalk);
            bInfo.AppendLine("Idle time: " + this.idleTime + " hours");

            return bInfo.ToString();
        }
    }
}
