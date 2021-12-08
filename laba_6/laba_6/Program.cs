using System;

namespace laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            LogBuffer logBuffer = new LogBuffer(5, 2000, "F:\\1.txt");

            for(int i = 0; i < 200; i++)
            {
                logBuffer.Add(i.ToString());
            }
            logBuffer.Close();
            Console.WriteLine("Готово");
            Console.ReadLine();
        }
    }
}
