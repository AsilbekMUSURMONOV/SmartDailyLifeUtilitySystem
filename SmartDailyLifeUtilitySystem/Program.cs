using System;

namespace SmartDailyLifeUtilitySystem
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Smart Daily Life Utility System =====");
                Console.WriteLine("1. Health Checker");
                Console.WriteLine("2. Shopping Calculator");
                Console.WriteLine("3. Text Analyzer");
                Console.WriteLine("4. Exit");

                int choice = ReadInt("Tanlang: ");

                switch (choice)
                {
                    case 1: HealthChecker(); break;
                    case 2: ShoppingCalculator(); break;
                    case 3: TextAnalyzer(); break;
                    case 4: return;
                    default: Error(); break;
                }
            }
        }
        static void HealthChecker()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Health Checker ===");
                Console.WriteLine("1. BMI hisoblash");
                Console.WriteLine("2. Ideal vazn");
                Console.WriteLine("3. Yosh kategoriyasi");
                Console.WriteLine("4. Back");

                int choice = ReadInt("Tanlang: ");
                if (choice == 4) return;

                switch (choice)
                {
                    case 1:
                        double h = ReadDouble("Bo‘y (metr): ");
                        double w = ReadDouble("Vazn (kg): ");
                        double bmi = Math.Round(w / (h * h), 2);

                        Console.WriteLine($"BMI: {bmi}");
                        Console.WriteLine(
                            bmi < 18.5 ? "Underweight" :
                            bmi < 25 ? "Normal" :
                            bmi < 30 ? "Overweight" : "Obese"
                        );
                        Pause();
                        break;

                    case 2:
                        double height = ReadDouble("Bo‘y (sm): ");
                        Console.WriteLine($"Ideal vazn: {(height - 100) * 0.9} kg");
                        Pause();
                        break;

                    case 3:
                        int age = ReadInt("Yosh: ");
                        Console.WriteLine(
                            age <= 12 ? "Child" :
                            age <= 19 ? "Teen" :
                            age <= 59 ? "Adult" : "Senior"
                        );
                        Pause();
                        break;

                    default:
                        Error();
                        break;
                }
            }
        }

        static void ShoppingCalculator()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Shopping Calculator ===");
                Console.WriteLine("1. Umumiy summa");
                Console.WriteLine("2. Chegirma");
                Console.WriteLine("3. QQS (12%)");
                Console.WriteLine("4. Back");

                int choice = ReadInt("Tanlang: ");
                if (choice == 4) return;

                switch (choice)
                {
                    case 1:
                        int n = ReadInt("Mahsulotlar soni: ");
                        double sum = 0;

                        for (int i = 0; i < n; i++)
                            sum += ReadDouble($"Narx {i + 1}: ");

                        Console.WriteLine($"Umumiy summa: {sum}");
                        Pause();
                        break;


                    case 2:
                        double total = ReadDouble("Summa: ");
                        double discount =
                            total > 1_000_000 ? total * 0.10 :
                            total >= 500_000 ? total * 0.05 : 0;
                        Console.WriteLine($"Chegirma: {discount}");
                        Console.WriteLine($"Yakuniy: {total - discount}");
                        Pause();
                        break;

                    case 3:
                        double s = ReadDouble("Summa: ");
                        Console.WriteLine($"QQS: {s * 0.12}");
                        Console.WriteLine($"Yakuniy: {s * 1.12}");
                        Pause();
                        break;

                    default:
                        Error();
                        break;
                }
            }
        }
        static void TextAnalyzer()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Text Analyzer ===");
                Console.WriteLine("1. So‘zlar soni");
                Console.WriteLine("2. Unli harflar soni");
                Console.WriteLine("3. Palindrom");
                Console.WriteLine("4. Back");

                int choice = ReadInt("Tanlang: ");
                if (choice == 4) return;
                switch (choice)
                {
                    case 1:
                        Console.Write("Matn: ");
                        string text = Console.ReadLine();
                        Console.WriteLine($"So‘zlar soni: {text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}");
                        Pause();
                        break;

                    case 2:
                        Console.Write("Matn: ");
                        string input = Console.ReadLine().ToLower();
                        int count = 0;
                        foreach (char c in input)
                            if ("aeiouo‘u‘".Contains(c)) count++;

                        Console.WriteLine($"Unli harflar: {count}");
                        Pause();
                        break;
                    case 3:
                        Console.Write("So‘z: ");
                        string word = Console.ReadLine().ToLower();
                        char[] arr = word.ToCharArray();
                        Array.Reverse(arr);

                        Console.WriteLine(word == new string(arr) ? "Palindrom" : "Palindrom emas");
                        Pause();
                        break;

                    default:
                        Error();
                        break;
                }
            }
        }
        static int ReadInt(string msg)
        {
            int x;
            Console.Write(msg);
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Qayta kiriting: ");
            return x;
        }
        static double ReadDouble(string msg)
        {
            double x;
            Console.Write(msg);
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.Write("Qayta kiriting: ");
            return x;
        }
        static void Pause()
        {
            Console.WriteLine("\nDavom etish uchun ENTER...");
            Console.ReadLine();
        }
        static void Error()
        {
            Console.WriteLine("Noto‘g‘ri tanlov!");
            Pause();
        }
    }
}

