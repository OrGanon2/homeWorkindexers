using System;
using System.Collections.Generic;
using System.Text;

namespace homeWorkindexers
{
    class Weather
    {
        public double[,] Temperture { get; set; } = new double[28, 1];
        private static readonly Random random = new Random();
        private static double randrange(double minvalue, double maxvalue)
        {
            var next = random.NextDouble();
            return minvalue + (next * (maxvalue - minvalue));
        }

        public Weather()
        {
            for (int i = 0; i < Temperture.Length; i++)
            {
                Temperture[i, 0] = Math.Round(randrange(24, 40), 2);
            }
        }
        public double GetMARRYWeather(string index)
        {
            try
            {
                int num = int.Parse(index);
                return Temperture[num - 1, 0];


            }
            catch
            {

                return 0.0;
            }
        }

        
    }
}
