using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Practick7
{
    public static class Menu
    {
       public static void Meenu(string[] Name) 
        {
            Console.WriteLine("Меню");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(Name, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < Name.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Escape:
                    {
                            Drive.Info(Name[index], true);
                        }
                        break;
                    case ConsoleKey.Enter:
                        { 
                                Console.WriteLine($"Выбран пункт {Name[index]}");
                                Console.Clear();
                            Drive.Info(Name[index]);
                            try
                            {
                                Drive.Info(Name[index]);
                            }
                            catch
                            {
                                var 
                                proc = new System.Diagnostics.Process();
                                proc.StartInfo.FileName = Name[index];
                                proc.StartInfo.UseShellExecute = true;
                                proc.Start();
                            }

                        }
                        break;
                }
            }
        }






        private static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                    Console.WriteLine($"{items[i]} \t \t \t {Directory.GetCreationTime(items[i])}" ); // вырисовка всего того что видит пользователь
                Console.ResetColor();
            }
            Console.WriteLine();


        }
    }
}
