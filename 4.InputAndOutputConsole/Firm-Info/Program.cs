using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 3

namespace Firm_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Firm name: ");
            string firmName = Console.ReadLine();
            Console.Write("Firm adress: ");
            string adress = Console.ReadLine();
            Console.Write("Firm telephone number: ");
            int telephone = int.Parse(Console.ReadLine());
            Console.Write("Firm FAX number: ");
            long faxNumber = long.Parse(Console.ReadLine());
            Console.Write("Firm Web site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager's first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager's telephone number ");
            int managerTelephone = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n" +
                "Adress: {1}\n" +
                "Telephone number: {2}, FAX number: {3}\n" +
                "website: {4}", firmName, adress, telephone, faxNumber, webSite);
            Console.WriteLine("Manager: {0} {1}\n" +
                "Telephone: {2}", managerFirstName, managerLastName, managerTelephone);
        }
    }
}
