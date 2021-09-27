using System;
namespace AdressbokEtt
{
    public static class ConsoleUtils2
    {
        public static string ReadString(string prompt = "")
        {
            if (!string.IsNullOrWhiteSpace(prompt))
            {
                Console.Write(prompt);
            }

            string input = Console.ReadLine();
            return input;
        }
        public static int ReadInt(string prompt = "")
        {
            if (!string.IsNullOrWhiteSpace(prompt))
            {
                Console.Write(prompt);
            }

            int.TryParse(Console.ReadLine(), out int output);
            return output;
        }
        public static double ReadDouble(string prompt = "")
        {
            if (!string.IsNullOrWhiteSpace(prompt))
            {
                Console.Write(prompt);
            }

            double.TryParse(Console.ReadLine(), out double output);
            return output;
        }
    }
}