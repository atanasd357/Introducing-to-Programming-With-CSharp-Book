using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMTest
    {
        public static void StartGSMTest()
        {
            //creating GSM objects
            GSM[] gsmArray =
            {
            new GSM("Xperia Z", "Sony", 569.99m, "Stefka", new Battery(BatteryType.NiCd, 30, 700),
            new Display(4.9m, 16000000)),

            new GSM("Galaxy S8", "Samsung", 779.99m, "Dimitar", new Battery(BatteryType.LiIon, 20, 420),
            new Display(5.8m, 32000000)),

            new GSM("Iphone 7", "", 1199.99m, "Atanas", new Battery(BatteryType.NiMH, 26, 500),
            new Display(4.7m, 32000000)),

            new GSM("Vibe C", "Lenovo", 349.99m, "Tanya", new Battery(BatteryType.LiPo, 18, 460),
            new Display(5.2m, 16000000))
        };

            //print info for every mobile phone
            foreach (GSM mobilePhone in gsmArray)
            {
                Console.WriteLine(mobilePhone);
            }

            //print GSM class static field
            Console.WriteLine(GSM.PrintStaticFieldInfo());
        }
    }
}
