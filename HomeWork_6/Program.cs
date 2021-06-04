using System;
using System.Diagnostics;

namespace HomeWork_6
{
    class Program
    {
        static void ForciblyClosingProcess()
        {
            Console.WriteLine("Running process on your PC: \n");
            Console.Write("ID".PadRight(10));
            Console.WriteLine("NameProcess\n");
            Process[] FileManager = Process.GetProcesses();
            foreach (var item in FileManager)
            {
                Console.Write($"{item.Id} ".PadRight(7));
                Console.WriteLine(item.ProcessName);
            }
            Console.Write("If you want to close process, write its ID or Name and press Enter: ");
            string nameProcessOrID;
            int id;
            do
            {
                nameProcessOrID = Console.ReadLine();
                try
                {
                    id = int.Parse(nameProcessOrID);
                }
                catch (Exception)
                {
                    id = -1;
                }
                for (int i = 0; i < FileManager.Length; i++)
                {
                    if (id == FileManager[i].Id)
                    {
                        FileManager[i].Kill();
                        break;
                    }
                    else if (FileManager[i].ProcessName == nameProcessOrID)
                    {
                        FileManager[i].Kill();
                        id = 0;
                        break;
                    }
                    else if (i == FileManager.Length - 1)
                    {
                        id = -1;
                    }
                }
                if (id == -1)
                    Console.WriteLine("There is no process with this ID or name. Try again...");
            } while (id == -1);
        }
        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {
                ForciblyClosingProcess();
                Console.WriteLine("To update the list of processes, press F5.\nTo exit, press ESC.\n");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                    break;
            } while (key == ConsoleKey.F5);
        }
    }
}
