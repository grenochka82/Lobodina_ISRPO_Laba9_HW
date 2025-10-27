//public class Thermometer
//{
//    public event Action<string>? TemperatureTooHigh;

//    private int currentTemperature;
//    private readonly int criticalTemperature = 100;

//    public void Measure(int temperature)
//    {
//        currentTemperature = temperature;
//        Console.WriteLine($"Измерена температура: {temperature}°C");

//        if (temperature > criticalTemperature)
//        {
//            string warning = $"ВНИМАНИЕ! Температура {temperature}°C превышает критическую {criticalTemperature}°C";
//            TemperatureTooHigh?.Invoke(warning);
//        }
//        else if (temperature > 80)
//        {
//            Console.WriteLine($"Температура {temperature}°C близка к критической");
//        }
//        else
//        {
//            Console.WriteLine("Температура в норме");
//        }
//    }

//    public int GetCurrentTemperature() => currentTemperature;
//}