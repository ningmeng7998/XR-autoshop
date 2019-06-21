using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome To XR Auto Shop ...");
                Console.WriteLine("Our products are as follows.");
                Console.WriteLine("");
                Console.WriteLine("/=============================================================================\\");
                Console.WriteLine("|   Package  Name   | Package  Code | Packs                                   |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
                Console.WriteLine("|  1- Sliced Ham    |      SH3      | 3 : $2.99 -  5 : $4.49                  |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
                Console.WriteLine("|  2- Yoghurt       |      YT2      | 4 : $4.95 - 10 : $9.95 - 15 : $13.95    |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
                Console.WriteLine("|  3- Toilet Rolls  |      TR       | 3 : $2.95 -  5 : $4.45 -  9 : $7.9      |");
                Console.WriteLine("\\=============================================================================/");
                Console.WriteLine("");
                Console.WriteLine("Please Enter your Package Code");
                Console.Write("> ");
                int CodeAccepted = 0;
                string PackCode = Console.ReadLine();
                PackCode = PackCode.Replace(" ", "").Replace(">", "");
                if (PackCode.Trim().ToUpper() == "SH3") { CodeAccepted = 1; }
                else if (PackCode.Trim().ToUpper() == "YT2") { CodeAccepted = 2; }
                else if (PackCode.Trim().ToUpper() == "TR")
                { CodeAccepted = 3; }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect Code Entered !");
                    Console.WriteLine("Press any key to try again ...");
                    Console.ReadLine();
                }
                if (CodeAccepted > 0)
                {
                    string Package_Code = "";
                    string Package_Name = "";
                    string Package_Count = "";
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    switch (CodeAccepted)
                    {
                        case 1: { Console.WriteLine("Selected Package : Sliced Ham"); Package_Code = "1"; Package_Name = "Sliced Ham"; break; }
                        case 2: { Console.WriteLine("Selected Package : Yoghurt"); Package_Code = "2"; Package_Name = "Yoghurt"; break; }
                        case 3: { Console.WriteLine("Selected Package : Toilet Rolls"); Package_Code = "3"; Package_Name = "Toilet Rolls"; break; }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Please Enter the Number of Packs You Need ...");
                    Console.Write("> ");
                    string PackCount = Console.ReadLine();
                    PackCount = PackCount.Replace(" ", "").Replace(">", "");
                    int PackCount_Dig = 0;
                    bool PC_OK = false;
                    Package_Count = PackCount;
                    try { PackCount_Dig = Int32.Parse(PackCount); PC_OK = true; } catch { PC_OK = false; }
                    if (PC_OK == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for Shopping in our store");
                        Console.WriteLine("Order Result :");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("  - Package Code  : " + Package_Code);
                        Console.WriteLine("  - Package Name  : " + Package_Name);
                        Console.WriteLine("  - Package Number : " + Package_Count);
                        Console.WriteLine("");
                        Console.WriteLine(" < --------------------------------------------- >");
                        Console.WriteLine("");
                        double Sum_Price = 0;
                        int ResFind = 0;
                        int ExitNow = 0;
                        int C1 = 0;
                        int C2 = 0;
                        int C3 = 0;
                        switch (CodeAccepted)
                        {
                            case 1:
                                {
                                    for (C1 = 0; C1 <= PackCount_Dig; C1++)
                                    {
                                        C2 = 0;
                                        for (C2 = 0; C2 <= PackCount_Dig; C2++)
                                        {
                                            if (((C1 * 3) + (C2 * 5)) == PackCount_Dig)
                                            {
                                                ResFind = 1;
                                                ExitNow = 1;
                                            }
                                            if (ExitNow == 1) { break; }
                                        }
                                        if (ExitNow == 1) { break; }
                                    }
                                    if (ResFind == 1)
                                    {
                                        if (C1 > 0) { Console.WriteLine("  - " + C1 + " x [3] $2.99"); Sum_Price += C1 * 2.99; }
                                        if (C2 > 0) { Console.WriteLine("  - " + C2 + " x [5] $4.49"); Sum_Price += C2 * 4.49; }
                                    }
                                    else
                                    { Console.WriteLine("  - Error !\r\n  - The number entered is not valid.\r\n  - Package is not available."); }
                                    break;
                                }
                            case 2:
                                {
                                    for (C1 = 0; C1 <= PackCount_Dig; C1++)
                                    {
                                        C2 = 0; C3 = 0;
                                        for (C2 = 0; C2 <= PackCount_Dig; C2++)
                                        {
                                            C3 = 0;
                                            for (C3 = 0; C3 <= PackCount_Dig; C3++)
                                            {
                                                if (((C1 * 4) + (C2 * 10) + (C3 * 15)) == PackCount_Dig)
                                                {
                                                    ResFind = 1;
                                                    ExitNow = 1;
                                                }
                                                if (ExitNow == 1) { break; }
                                            }
                                            if (ExitNow == 1) { break; }
                                        }
                                        if (ExitNow == 1) { break; }
                                    }
                                    if (ResFind == 1)
                                    {
                                        if (C1 > 0) { Console.WriteLine("  - " + C1 + " x [4] $4.95"); Sum_Price += C1 * 4.95; }
                                        if (C2 > 0) { Console.WriteLine("  - " + C2 + " x [10] $9.95"); Sum_Price += C2 * 9.95; }
                                        if (C3 > 0) { Console.WriteLine("  - " + C3 + " x [15] $13.95"); Sum_Price += C3 * 13.95; }
                                    }
                                    else
                                    { Console.WriteLine("  - Error !\r\n  - The number entered is not valid.\r\n  - Package is not available."); }
                                    break;
                                }
                            case 3:
                                {
                                    for (C1 = 0; C1 <= PackCount_Dig; C1++)
                                    {
                                        C2 = 0; C3 = 0;
                                        for (C2 = 0; C2 <= PackCount_Dig; C2++)
                                        {
                                            C3 = 0;
                                            for (C3 = 0; C3 <= PackCount_Dig; C3++)
                                            {
                                                if (((C1 * 3) + (C2 * 5) + (C3 * 9)) == PackCount_Dig)
                                                {
                                                    ResFind = 1;
                                                    ExitNow = 1;
                                                }
                                                if (ExitNow == 1) { break; }
                                            }
                                            if (ExitNow == 1) { break; }
                                        }
                                        if (ExitNow == 1) { break; }
                                    }
                                    if (ResFind == 1)
                                    {
                                        if (C1 > 0) { Console.WriteLine("  - " + C1 + " x [3] $2.95"); Sum_Price += C1 * 2.95; }
                                        if (C2 > 0) { Console.WriteLine("  - " + C2 + " x [5] $4.45"); Sum_Price += C2 * 4.45; }
                                        if (C3 > 0) { Console.WriteLine("  - " + C3 + " x [9] $7.99"); Sum_Price += C3 * 7.99; }
                                    }
                                    else
                                    { Console.WriteLine("  - Error !\r\n  - The number entered is not valid.\r\n  - Package is not available."); }
                                    break;
                                }
                        }
                        Console.WriteLine("");
                        Console.WriteLine(" < --------------------------------------------- >");
                        Console.WriteLine("");
                        Console.WriteLine("  Total Price  : $ " + Sum_Price);
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to try again ...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Incorrect Packs Number Entered !");
                        Console.WriteLine("Press any key to try again ... ");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
