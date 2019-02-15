using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 11

namespace Numbers_from_One_to_One_Hundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());

            int hunderts = (num / 100) % 10;
            int tens = (num / 10) % 10;
            int units = num % 10;
            string hndr = "";
            string tns = "";
            string unt = "";

            if (num >= 0 && num <= 9)
            {
                switch (units)
                {
                    case 0: unt = "нула"; break;
                    case 1: unt = "едно"; break;
                    case 2: unt = "две"; break;
                    case 3: unt = "три"; break;
                    case 4: unt = "четири"; break;
                    case 5: unt = "пет"; break;
                    case 6: unt = "шест"; break;
                    case 7: unt = "седем"; break;
                    case 8: unt = "осем"; break;
                    case 9: unt = "девет"; break;
                }

                Console.WriteLine(unt);
            }

            else if (num >= 10 && num <= 99)
            {
                if (num >= 11 && num <= 19)
                {
                    switch (num / 10)
                    {
                        case 11: tns = "единадесет"; break;
                        case 12: tns = "дванадесет"; break;
                        case 13: tns = "тринадесет"; break;
                        case 14: tns = "четиринадесет"; break;
                        case 15: tns = "петнадесет"; break;
                        case 16: tns = "шестнадесет"; break;
                        case 17: tns = "седемнадесет"; break;
                        case 18: tns = "осемнадесет"; break;
                        case 19: tns = "деветнадесет"; break;
                    }
                }
                else if (num == 10 || (num >= 20 && num <= 99))
                {
                    if (units == 0)
                    {
                        switch (tens)
                        {
                            case 1: tns = "десет"; break;
                            case 2: tns = "двадесет"; break;
                            case 3: tns = "тридесет"; break;
                            case 4: tns = "четиридесет"; break;
                            case 5: tns = "петдесет"; break;
                            case 6: tns = "шестдесет"; break;
                            case 7: tns = "седемдесет"; break;
                            case 8: tns = "осемдесет"; break;
                            case 9: tns = "деветнадесет"; break;
                        }

                        Console.WriteLine(tns);
                    }
                    else
                    {
                        switch (tens)
                        {
                            case 2: tns = "двадесет"; break;
                            case 3: tns = "тридесет"; break;
                            case 4: tns = "четиридесет"; break;
                            case 5: tns = "петдесет"; break;
                            case 6: tns = "шестдесет"; break;
                            case 7: tns = "седемдесет"; break;
                            case 8: tns = "осемдесет"; break;
                            case 9: tns = "деветдесет"; break;
                        }

                        switch (units)
                        {
                            case 1: unt = "едно"; break;
                            case 2: unt = "две"; break;
                            case 3: unt = "три"; break;
                            case 4: unt = "четири"; break;
                            case 5: unt = "пет"; break;
                            case 6: unt = "шест"; break;
                            case 7: unt = "седем"; break;
                            case 8: unt = "осем"; break;
                            case 9: unt = "девет"; break;
                        }

                        Console.WriteLine(tns + " и " + unt);
                    }
                }
            }

            else if (num >= 100 && num <= 999)
            {
                switch (hunderts)
                {
                    case 1: hndr = "сто"; break;
                    case 2: hndr = "двеста"; break;
                    case 3: hndr = "триста"; break;
                    case 4: hndr = "четиристотин"; break;
                    case 5: hndr = "петстотин"; break;
                    case 6: hndr = "шестотин"; break;
                    case 7: hndr = "седемстотин"; break;
                    case 8: hndr = "осемстотин"; break;
                    case 9: hndr = "деветстотин"; break;
                }

                if (units == 0)
                {
                    switch (tens)
                    {
                        case 1: tns = "десет"; break;
                        case 2: tns = "двадесет"; break;
                        case 3: tns = "тридесет"; break;
                        case 4: tns = "четиридесет"; break;
                        case 5: tns = "петдесет"; break;
                        case 6: tns = "шестдесет"; break;
                        case 7: tns = "седемдесет"; break;
                        case 8: tns = "осемдесет"; break;
                        case 9: tns = "деветнадесет"; break;
                    }

                    Console.WriteLine(hndr + " и " + tns);
                }

                else if (tens == 1 && (units >= 1 && units <= 9))
                {
                    switch (num % 100)
                    {
                        case 11: tns = "единадесет"; break;
                        case 12: tns = "дванадесет"; break;
                        case 13: tns = "тринадесет"; break;
                        case 14: tns = "четиринадесет"; break;
                        case 15: tns = "петнадесет"; break;
                        case 16: tns = "шестнадесет"; break;
                        case 17: tns = "седемнадесет"; break;
                        case 18: tns = "осемнадесет"; break;
                        case 19: tns = "деветнадесет"; break;
                    }

                    Console.WriteLine(hndr + " и " + tns);
                }

                else
                {
                    switch (tens)
                    {
                        case 2: tns = "двадесет"; break;
                        case 3: tns = "тридесет"; break;
                        case 4: tns = "четиридесет"; break;
                        case 5: tns = "петдесет"; break;
                        case 6: tns = "шестдесет"; break;
                        case 7: tns = "седемдесет"; break;
                        case 8: tns = "осемдесет"; break;
                        case 9: tns = "деветдесет"; break;
                    }

                    switch (units)
                    {
                        case 1: unt = "едно"; break;
                        case 2: unt = "две"; break;
                        case 3: unt = "три"; break;
                        case 4: unt = "четири"; break;
                        case 5: unt = "пет"; break;
                        case 6: unt = "шест"; break;
                        case 7: unt = "седем"; break;
                        case 8: unt = "осем"; break;
                        case 9: unt = "девет"; break;
                    }

                    Console.WriteLine(hndr + " " + tns + " и " + unt);
                }
            }
        }
    }
}
