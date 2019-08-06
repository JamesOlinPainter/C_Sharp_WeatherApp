using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public class weatherLibrary
    {
        public static double FahrenheitToCelsius(double F)
        {
            return ((F - 32.00) * (5 / 9));
        }

        public static double FahrenheitToKelvin(double F)
        {
            return (((F - 32.00) * (5 / 9)) + 273.15);
        }

        public static double CelsiusToFahrenheit(double C)
        {
            return (C * (9 / 5) + 32);
        }

        public static double CelsiusToKelvin(double C)
        {
            return (C + 273.15);
        }

        public static double KelvinToCelsius(double K)
        {
            return (K - 273.15);
        }

        public static double KelvinToFahrenheit(double K)
        {
            return (((K - 273.15) * (9 / 5)) + 32);
        }

        public static double heatIndex(double T, double RH)
        {
            return (-42.379 + 2.04901523 * T + 10.14333127 * RH - .22475541 * T * RH - .00683783 * T * T - .05481717 * RH * RH + .00122874 * T * T * RH + .00085282 * T * RH * RH - .00000199 * T * T * RH * RH);
        }

        public static double windChill_C(double T, double V)
        {   //  calculation for wind chill in Celsius.
            return (13.12 + (0.6215 * T) - (11.37 * Math.Pow(V, 0.16)) + (0.3965 * T * Math.Pow(V, 0.16)));
        }

        public static double windChill_F(double T, double V)
        {   //  calculation for wind chill in Celsius.
            return (35.74 + (0.6215 * T) - (35.75 * Math.Pow(V, 0.16)) + (0.4275 * T * Math.Pow(V, 0.16)));
        }

        public static double dewPoint_C(double T, double rh)
        {   //  calculation for dew point in Celsius.
            return (T - ((100 - rh) / 5));
        }

        public static double virtualTemperature(double T, double DP, double SP)
        {   //  input temp in Celsius, output temp in Kelvin.
            return ((T + 273.15) / (1 - (0.379 * ((6.11 * Math.Pow(10, ((7.5 * DP) / (237.7 + DP)))) / SP))));
        }

        public static double humidity(double T, double DP)
        {   //  
            double saturationVaporPressure = (6.11 * Math.Pow(10.0, (7.5 * T / (237.7 + T))));
            double actualVaporPressure = (6.11 * Math.Pow(10.0, (7.5 * DP / (237.7 + DP))));
            return ((actualVaporPressure / saturationVaporPressure) * 100);
        }
    
        public static double volumeOfRain(double surfaceArea, double depth)
        {
            return surfaceArea * depth;
        }

        public static double[] mixingRatio(double temperature, double dewPoint, double stationPressure)
        {
            double saturationVaporPressure = (6.11 * Math.Pow(10.0, (7.5 * temperature / (237.7 + temperature))));
            double actualVaporPressure = (6.11 * Math.Pow(10.0, (7.5 * dewPoint / (237.7 + dewPoint))));
            double AMR = (621.97 * (actualVaporPressure / (stationPressure - actualVaporPressure)));
            double SMR = (621.97 * (saturationVaporPressure / (stationPressure - saturationVaporPressure)));
            double[] AandSMR = { AMR, SMR };
            return AandSMR;
        }

        public static double MPHtoKnots(double mph)
        {
            return (mph / 1.15078);
        }

        public static double KnotsToMPH(double knots)
        {
            return (knots * 1.15078);
        }
    }
}
