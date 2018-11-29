using System;
namespace ConsoleApplication
{
    public class Tema02ex02 
    {
        public static void Main()
        {
            Console.WriteLine("Please add your number for temperature conversions: ");
            string newNo1 = Console.ReadLine();//preluare string interogare 1

            double no01 = Convert.ToDouble(newNo1);//conversie string interogare 1 to double

            double vCels = fFtoC(no01);
            Console.WriteLine("If you number is Fahrenheit degrees, it's conversion to Celsius degrees is equal to: " + vCels.ToString());

            double vFahr = fCtoF(no01);
            Console.WriteLine("If you number is Celsius degrees, it's conversion to Fahrenheit degrees is equal to: " + vFahr.ToString());
            Console.WriteLine("-------------------------------------------------------------------------------------");
            //-----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Please add your number for calendar conversion: ");
            string newNo2 = Console.ReadLine();//preluare string interogare 2 in variabila newNo2

            int no02 = Convert.ToInt32(newNo2);//conversia variabilei string newNo2 in variabila tip Int32 no02

            int vAni = fAni(no02);//preluare valori returnate de functiile fAni, fLuni, fSapt, fZile in variabilele vAni, vLuni, vSapt, vZile declarate de tip Int32
            int vLuni = fLuni(no02);
            int vSapt = fSapt(no02);
            int vZile = fZile(no02);
            Console.WriteLine("The number you added means " + vAni.ToString() + " year(s), " + vLuni.ToString() + " month(s), " + vSapt.ToString() + " week(s) and " + vZile.ToString() + " day(s).");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
        public static double fFtoC(double no03)//functia de conversie a grd Fahrenheit in grd Celsius
        {
            double vCels = (5.0 / 9.0) * (no03 - 32);
            return vCels;
        }
        public static double fCtoF(double no04)//functia de conversie a grd Celsius in grd Fahrenheit
        {
            double vFahr = ((9.0 / 5.0) * no04) + 32;
            return vFahr;
        }
        public static int fAni(int no05)//calculeaza numarul anilor
        {
            int vAni = no05 / 365;
            return vAni;
        }
        public static int fLuni(int no06)//calculeaza numarul lunilor
        {
            int vLuni = (no06 % 365) / 30;
            return vLuni;
        }
        public static int fSapt(int no07)//calculeaza numarul saptamanilor
        {
            int vAni = fAni(no07);
            int vLuni = fLuni(no07);
            int vSapt = (no07 - vAni * 365 - vLuni * 30) / 7;
            return vSapt;
        }
        public static int fZile(int no08)//calculeaza numarul zilelor
        {
            int vAni = fAni(no08);
            int vLuni = fLuni(no08);
            int vSapt = fSapt(no08);
            int vZile = no08 - vAni * 365 - vLuni * 30 - vSapt * 7;
            return vZile;
        }
    }
}