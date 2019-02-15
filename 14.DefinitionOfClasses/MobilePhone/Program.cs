using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            //run GSMTest class
            GSMTest.StartGSMTest();

            //run GSMCallHIstoryTest class
            GSMCallHistoryTest.StartGSMCallHistoryTest();
        }
    }
}
