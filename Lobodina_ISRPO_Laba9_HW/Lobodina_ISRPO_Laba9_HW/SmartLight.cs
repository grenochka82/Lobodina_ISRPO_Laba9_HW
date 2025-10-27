//using Newtonsoft.Json;
//using System.Xml;

//public class SmartLight
//{
//    public event Action<string>? OnStateChanged;
//    public bool IsOn { get; private set; }
//    public int Brightness { get; private set; } = 100;
//    public string Color { get; private set; } = "White";
//    private readonly int maxBrightness = 100;
//    private readonly int minBrightness = 10;
//    public void Toggle()
//    {
//        IsOn = !IsOn;
//        string state = IsOn ? "включён" : "выключен";
//        OnStateChanged?.Invoke($"Свет {state}");

//        Console.WriteLine($" Свет {state} (яркость: {Brightness}%)");
//    }
//    public void SetBrightness(int brightness)
//    {
//        int oldBrightness = Brightness;
//        Brightness = Math.Clamp(brightness, minBrightness, maxBrightness);

//        if (oldBrightness != Brightness)
//        {
//            Console.WriteLine($" Яркость изменена: {oldBrightness}% → {Brightness}%");

//            if (IsOn)
//            {
//                OnStateChanged?.Invoke($"Яркость изменена на {Brightness}%");
//            }
//        }
//    }
//    public void SetColor(string color)
//    {
//        string[] allowedColors = { "White", "Warm White", "Red", "Green", "Blue", "Yellow" };

//        if (allowedColors.Contains(color))
//        {
//            string oldColor = Color;
//            Color = color;
//            Console.WriteLine($"🎨 Цвет изменён: {oldColor} → {Color}");

//            if (IsOn)
//            {
//                OnStateChanged?.Invoke($"Цвет изменён на {color}");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Недопустимый цвет: {color}");
//        }
//    }
//    public string ToJson()
//    {
//        var state = new
//        {
//            IsOn,
//            Brightness,
//            Color,
//            Timestamp = DateTime.Now
//        };

//        return JsonConvert.SerializeObject(state, Formatting.Indented);
//    }
//    public static SmartLight? FromJson(string json)
//    {
//        try
//        {
//            var state = JsonConvert.DeserializeObject<dynamic>(json);
//            if (state != null)
//            {
//                var light = new SmartLight();
//                return light;
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка десериализации: {ex.Message}");
//        }

//        return null;
//    }
//}