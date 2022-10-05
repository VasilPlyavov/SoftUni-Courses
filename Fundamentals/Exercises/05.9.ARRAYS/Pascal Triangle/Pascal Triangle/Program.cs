using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int dimension = int.Parse(Console.ReadLine());//izchitame konzolata;

            Console.WriteLine(1);//imame opredelen pyrvi red i pecatame
            int[] previous = new int[] { 1 };//masiv s edna edinica koqto e otpechatana

            for (int i = 2; i <= dimension; i++)//otpechatvame 
            {

                int[] values = new int[i];//nov masiv s poreden nomer na reda
                values[0] = 1;//pyrvata i poslednata cifra vinagi sa edinici
                values[i - 1] = 1;//pyrvata i pooslednata vinagi sa edinici

                for (int j = 1; j < i - 1; j++)//
                {
                    values[j] = previous[j - 1] + previous[j];//formulata za da smetnem vzemaneto na st-sti


                }
                Console.WriteLine(string.Join(' ', values));
                previous = values;//minavame na sledvasht red;
            }

        }
    }
}
