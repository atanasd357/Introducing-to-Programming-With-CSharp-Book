using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMCallHistoryTest
    {
        public static void StartGSMCallHistoryTest()
        {
            //add mobile phone for test
            Console.WriteLine("GSM for call history test\n");
            GSM testPhone = new GSM("Iphone 8", "", 1699.99m, "Georgi", new Battery(BatteryType.NiMH, 40, 800),
                 new Display(5.2m, 32000000));

            //add calls made with the test phone
            testPhone.AddCall(DateTime.Today, DateTime.Today.AddSeconds(34));
            testPhone.AddCall(DateTime.Today, DateTime.Today.AddMinutes(3).AddSeconds(20));
            testPhone.AddCall(DateTime.Today, DateTime.Today.AddMinutes(5).AddSeconds(2));
            testPhone.AddCall(DateTime.Today, DateTime.Today.AddSeconds(24));
            testPhone.AddCall(DateTime.Now, DateTime.Now.AddMinutes(4));
            testPhone.AddCall(DateTime.Now, DateTime.Now.AddSeconds(57));
            testPhone.AddCall(DateTime.Now, DateTime.Now.AddSeconds(49));
            testPhone.AddCall(DateTime.Now, DateTime.Now.AddMinutes(7).AddSeconds(42));

            //print test phone info
            Console.WriteLine(testPhone);

            //calculate and print price for all calls made with the test phone
            decimal price = testPhone.CalculateAllCallsPrice(0.37m);
            Console.WriteLine("Price for all calls is: {0:f2} lv.\n", price);

            //removing call in position 5 in calls list
            testPhone.RemoveCall(5);
            foreach(Call call in testPhone.CallsList)
            {
                Console.WriteLine(call);
            }
            price = testPhone.CalculateAllCallsPrice(0.37m);
            Console.WriteLine("\nPrice for all calls is: {0:f2} lv.\n", price);

            //removing longest call in calls list
            testPhone.RemoveLongestCall();
            foreach (Call call in testPhone.CallsList)
            {
                Console.WriteLine(call);
            }
            price = testPhone.CalculateAllCallsPrice(0.37m);
            Console.WriteLine("\nPrice for all calls is: {0:f2} lv.\n", price);

            //removing all calls in calls list
            testPhone.RemoveAllCalls();
            foreach (Call call in testPhone.CallsList)
            {
                Console.WriteLine(call);
            }
            price = testPhone.CalculateAllCallsPrice(0.37m);
            Console.WriteLine("Price for all calls is: {0:f2} lv.\n", price);
        }
    }
}
