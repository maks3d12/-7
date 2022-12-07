using System;
using System.IO;

namespace Practick7
{
    class Test 
    {

        public static void Main() // окей, тут будут комменты для будущего читателя
        {

            DriveInfo[] drives = DriveInfo.GetDrives();
         

            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(drives, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < drives.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 2:
                                Console.WriteLine("Выбран выход из приложения");
                                return;
                            default:
                                Console.WriteLine($"Выбран пункт {drives[index]}");
                                Drive.Info(drives[index].Name);
                                Thread.Sleep(5000);

                                break;
                        }
                        break;
                }
            }
        }

        private static void DrawMenu(DriveInfo[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (items[i].IsReady)
                {
                    Console.WriteLine($"Название: {items[i].Name} Свободно Гб: {items[i].TotalFreeSpace / 1000000000} из {items[i].TotalSize / 1000000000 }");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

}



