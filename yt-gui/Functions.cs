using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_gui
{
    static class Functions
    {
        public static void WriteToSettings(int line, string text)
        {
            if (File.Exists("settings.txt"))
            {
                string[] lines = File.ReadAllLines("settings.txt");
                lines[line] = text;
                File.WriteAllLines("settings.txt", lines);
            } else
            {
                using (StreamWriter sw = new StreamWriter("settings.txt"))
                {
                    sw.WriteLine(text);
                }
            }
            
        }

        // Try to load the dependencies folder from settings file, if not present, highlight setup button
        public static void LoadSettings()
        {
            Button temp = Application.OpenForms["MainForm"].Controls["SetupButton"] as Button;
            try
            {
                using (StreamReader sr = new StreamReader("settings.txt"))
                {
                    string dep = sr.ReadLine();
                    temp.BackColor = Color.FromName("Control");
                }
            }
            catch
            {
                temp.BackColor = Color.Red;
            }
        }

        //private static void LoadSettings()
        //{
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader("settings.txt"))
        //        {
        //            string dep = sr.ReadLine();
        //            SetupButton.BackColor = Color.FromName("Control");
        //        }
        //    }
        //    catch
        //    {
        //        SetupButton.BackColor = Color.Red;
        //    }
        //}
    }
}
