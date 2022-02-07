namespace Temperature
{
    public class Conversion
    {
        public enum ConversionMode {
            Celsius_to_Fahrenheit,
            Kelvin_to_Fahrenheit,
            Fahrenheit_to_Celsius,
            Celsius_to_Kelvin,
            Kelvin_to_Celsius,
            Fahrenheit_to_Kelvin

        }
        public double Convert(ConversionMode mode, double temperature) {
            double result = 0d;
            switch (mode) {
                case ConversionMode.Celsius_to_Fahrenheit:
                    result = (9d/5d * temperature) + 32d;
                    break;
                case ConversionMode.Kelvin_to_Fahrenheit:
                    // 9/5 (K - 273) + 32
                    result = (9d/5d *(temperature-273) +32d);
                    break;
                case ConversionMode.Fahrenheit_to_Celsius:
                    // ° C = 5/9 (° F - 32)
                    result = (5d/9d *(temperature-32));
                    break;
                case ConversionMode.Celsius_to_Kelvin:
                    // K = ° C + 273
                    result = temperature + 273;
                    break;
                case ConversionMode.Kelvin_to_Celsius:
                    // ° C = K - 273
                    result = temperature -273;
                    break;
                case ConversionMode.Fahrenheit_to_Kelvin:
                    // K = 5/9 (° F - 32) + 273
                    // result = 5d/9d *(temperature - 32) +273;
                    result = 5d/9d *(temperature - 31) +273;
                    break;
            }
            return Math.Round(result, 2);
        }
    }
}