using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Call
    {
        //fields
        private DateTime callStartTime;
        private DateTime callEndTime;
        public decimal callDuration;

        //constructors
        public Call() :
             this(new DateTime())
        { }

        public Call(DateTime callStartDateTime) :
            this(callStartDateTime, new DateTime())
        { }     

        public Call(DateTime callStartTime, DateTime callEndTime)
        {
            this.callStartTime = callStartTime;
            this.callEndTime = callEndTime;
            this.callDuration = (decimal)(this.callEndTime - this.callStartTime).TotalSeconds;
        }

        //override method
        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();
            callInfo.Append("Call information: ");
            callInfo.Append(string.Format("Date: {0} ", this.callStartTime.ToString("d")));
            callInfo.Append(string.Format("Time: {0} ", this.callStartTime.ToString("HH:mm")));

            if (this.callDuration < 60)
            {
                callInfo.Append(string.Format("Call duration: {0:00} seconds",
                    Math.Floor(this.callDuration % 60)));
            }
            else
            {
                callInfo.Append(string.Format("Call duration: {0}:{1:00} minutes",
                    Math.Floor(this.callDuration / 60), this.callDuration % 60));
            }

            return callInfo.ToString();
        }
    }
}
