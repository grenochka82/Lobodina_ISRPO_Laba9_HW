//using HtmlAgilityPack;

//static async Task Task2_HtmlParsing()
//{
//    Console.WriteLine();

//    try
//    {
//        var web = new HtmlWeb();
//        var doc = await web.LoadFromWebAsync("https://example.com");
//        var titleNode = doc.DocumentNode.SelectSingleNode("//title");
//        var h1Node = doc.DocumentNode.SelectSingleNode("//h1");
//        var paragraphNodes = doc.DocumentNode.SelectNodes("//p");
//        Console.WriteLine($"Заголовок страницы: {titleNode?.InnerText}");
//        Console.WriteLine($"H1: {h1Node?.InnerText}");

//        if (paragraphNodes != null)
//        {
//            Console.WriteLine($"Найдено параграфов: {paragraphNodes.Count}");
//            foreach (var p in paragraphNodes.Take(3)) 
//            {
//                Console.WriteLine($"Параграф: {p.InnerText.Trim()}");
//            }
//        }
//        var linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");
//        if (linkNodes != null)
//        {
//            Console.WriteLine($"\nНайдено ссылок: {linkNodes.Count}");
//            foreach (var link in linkNodes.Take(5)) 
//            {
//                string href = link.GetAttributeValue("href", "");
//                Console.WriteLine($"Ссылка: {link.InnerText.Trim()} -> {href}");
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ошибка при парсинге: {ex.Message}");
//    }
//}
//3
//public delegate void Logger(string message);

//static void Task3_Delegates()
//{
//    Console.WriteLine();
//    Logger logger = LogToConsole;
//    logger("Тестовое сообщение через делегат");
//    logger += LogToConsoleWithTimestamp;
//    logger += LogToFileSimulation;
//    Console.WriteLine("\nМультикаст делегат:");
//    logger("Сообщение для всех подписчиков");
//    logger -= LogToFileSimulation;
//    Console.WriteLine("\nПосле удаления LogToFileSimulation:");
//    logger("Финальное сообщение");
//    ProcessMessages(new string[] { "Первое", "Второе", "Третье" }, LogToConsoleWithTimestamp);
//}

//static void LogToConsole(string message)
//{
//    Console.WriteLine($"[CONSOLE] {message}");
//}

//static void LogToConsoleWithTimestamp(string message)
//{
//    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
//}

//static void LogToFileSimulation(string message)
//{
//    Console.WriteLine($"[FILE] Запись в файл: {message}");
//}

//static void ProcessMessages(string[] messages, Logger logger)
//{
//    Console.WriteLine("\nОбработка массива сообщений:");
//    foreach (string msg in messages)
//    {
//        logger(msg);
//    }
//}
//4
//static void Task4_ThermometerEvents()
//{
//    Console.WriteLine();
//    Thermometer thermometer = new Thermometer();
//    thermometer.TemperatureTooHigh += (message) =>
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($" СИГНАЛИЗАЦИЯ: {message}");
//        Console.ResetColor();
//        Console.WriteLine("Действия: отключение оборудования, отправка уведомления...");
//    };
//    thermometer.TemperatureTooHigh += (message) =>
//    {
//        Console.WriteLine($"[Лог] Зафиксирована критическая температура в {DateTime.Now:HH:mm:ss}");
//    };
//    int[] testTemperatures = { 25, 75, 95, 105, 120, 80 };

//    foreach (int temp in testTemperatures)
//    {
//        Console.WriteLine($"\n--- Измерение {temp}°C ---");
//        thermometer.Measure(temp);
//        Thread.Sleep(1000); 
//    }
//}
//static void Task5_NullHandling()
//{
//    Console.WriteLine("\n=== Задание 5: Работа с null ===");
//    string?[] testStrings = {
//        "Hello World",
//        null,
//        "   ",
//        "",
//        "Normal String",
//        null,
//        "Another test string with spaces"
//    };
//    Console.WriteLine("Обработка массива строк:");
//    foreach (string? str in testStrings)
//    {
//        PrintLength(str);
//    }
//    Console.WriteLine("\nДополнительные примеры:");
//    string? userInput = GetUserInputSimulation();
//    PrintLength(userInput);
//    string? fromDatabase = GetFromDatabaseSimulation(1); 
//    PrintLength(fromDatabase);
//    fromDatabase = GetFromDatabaseSimulation(999); 
//    PrintLength(fromDatabase);
//}
//static void PrintLength(string? input)
//{
//    if (input == null)
//    {
//        Console.WriteLine(" Строка отсутствует (null)");
//    }
//    else if (string.IsNullOrWhiteSpace(input))
//    {
//        Console.WriteLine(" Строка пустая или состоит только из пробелов");
//    }
//    else
//    {
//        Console.WriteLine($" Длина строки '{input.Trim()}': {input.Trim().Length} символов");
//    }
//}
//static string? GetUserInputSimulation()
//{
//    Random rnd = new Random();
//    return rnd.Next(0, 3) switch
//    {
//        0 => "Пользовательский ввод",
//        1 => null,
//        _ => "   "
//    };
//}
//static string? GetFromDatabaseSimulation(int id)
//{
//    return id switch
//    {
//        1 => "Данные из базы",
//        2 => null,
//        3 => "   ",
//        _ => null 
//    };
//}