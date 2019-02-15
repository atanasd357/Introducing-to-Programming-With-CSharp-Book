using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        //static field
        private static readonly GSM htcDesire610 = new GSM("Desire 610", "HTC", 620.99m, "Atanas",
            new Battery(BatteryType.LiPo, 16, 650),
            new Display(4.7m, 16000000));

        //non-static fields
        private string model = null;
        private string manufactuer = null;
        private decimal price = 0;
        private string owner = null;

        private Battery battery = new Battery(BatteryType.LiIon, 0, 0);
        private Display display = new Display(0, 0);

        private List<Call> callsList = new List<Call>();

        //constructors
        public GSM() :
            this(null)
        { }

        public GSM(string model) :
            this(model, null)
        { }

        public GSM(string model, string manufactuer) :
            this(model, manufactuer, 0)
        { }

        public GSM(string model, string manufactuer, decimal price) :
            this(model, manufactuer, price, null)
        { }

        public GSM(string model, string manufactuer, decimal price, string owner) :
            this(model, manufactuer, price, owner, new Battery())
        { }

        public GSM(string model, string manufactuer, decimal price, string owner, Battery battery) :
            this(model, manufactuer, price, owner, battery, new Display())
        { }

        public GSM(string model, string manufactuer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufactuer = manufactuer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        //properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufactuer
        {
            get { return this.manufactuer; }
            set { this.manufactuer = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public List<Call> CallsList
        {
            get { return this.callsList; }
            set { this.callsList = value; }
        }

        //methods
        public void AddCall(DateTime callStartTime, DateTime callEndTime)
        {
            this.callsList.Add(new Call(callStartTime, callEndTime));
        }

        public void RemoveCall(int callForRemove)
        {
            this.callsList.RemoveAt(callForRemove);
        }

        public void RemoveLongestCall()
        {
            decimal longestCallDuration = 0;
            Call longestCall = null;

            foreach (Call call in this.callsList)
            {
                if (call.callDuration > longestCallDuration)
                {
                    longestCallDuration = call.callDuration;
                    longestCall = call;
                }
            }

            this.callsList.Remove(longestCall);
        }

        public void RemoveAllCalls()
        {
            this.callsList.Clear();
        }

        public decimal CalculateAllCallsPrice(decimal priceForMinute)
        {
            decimal sumCallsMinutes = 0;
            foreach (Call call in callsList)
            {
                sumCallsMinutes += call.callDuration / 60;
            }

            decimal allCallsPrice = sumCallsMinutes * priceForMinute;
            return allCallsPrice;
        }

        public static string PrintStaticFieldInfo()
        {
            StringBuilder stFieldInfoPrint = new StringBuilder();
            stFieldInfoPrint.AppendLine("Static field info:\n");
            stFieldInfoPrint.AppendLine("Model: " + htcDesire610.model);
            stFieldInfoPrint.AppendLine("Manufactuer: " + htcDesire610.manufactuer);
            stFieldInfoPrint.AppendLine("Price: " + htcDesire610.price + " lv.");
            stFieldInfoPrint.AppendLine("Owner: " + htcDesire610.owner);
            stFieldInfoPrint.Append(htcDesire610.battery.PrintBatteryInfo());
            stFieldInfoPrint.Append(htcDesire610.display.PrintDisplayInfo());

            return stFieldInfoPrint.ToString();
        }

        //override method
        public override string ToString()
        {
            StringBuilder gsmInfoPrint = new StringBuilder();
            gsmInfoPrint.AppendLine("GSM Info:");
            gsmInfoPrint.AppendLine("Model: " + this.model);
            gsmInfoPrint.AppendLine("Manufactuer: " + this.manufactuer);
            gsmInfoPrint.AppendLine("Price: " + this.price + " lv.");
            gsmInfoPrint.AppendLine("Owner: " + this.owner);
            gsmInfoPrint.Append(this.battery.PrintBatteryInfo());
            gsmInfoPrint.Append(this.display.PrintDisplayInfo());
            gsmInfoPrint.AppendLine();

            if (this.callsList.Count != 0)
            {
                foreach (Call call in this.callsList)
                {
                    gsmInfoPrint.Append(call);
                    gsmInfoPrint.AppendLine();
                }
                return gsmInfoPrint.ToString();
            }
            else
            {
                gsmInfoPrint.AppendLine(string.Format("There is not any call in calls history!"));
                return gsmInfoPrint.ToString();
            }
        }
    }
}
