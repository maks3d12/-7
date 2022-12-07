using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practick7
{
    public static class Drive
    {
    public static void Info(string path, bool esc = false) // Переменная esc создана только ради escape в программе
        {
            Console.Clear();
            if (esc) // вот проверка на нажатие
            {
                try 
                { 
                path = Directory.GetParent(path).FullName;
                path = Directory.GetParent(path).FullName;
                }
                catch(NullReferenceException)
                {
                    Test.Main(); // чтобы программа не вылетала при повторном нажатии esc, мы начинаем ее с начала, рекурсивно :D 
                }
              
            }
            string[] manypath = Directory.GetFileSystemEntries(path);
            if (Directory.Exists(path))
            {
                Menu.Meenu(manypath);
            }
        }
    }
}
