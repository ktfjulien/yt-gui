using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt_gui
{
    public partial class MainForm : Form
    {
        public static void WriteToSettings(int line, string text)
        {
            if (File.Exists("settings.txt"))
            {
                string[] lines = File.ReadAllLines("settings.txt");
                lines[line] = text;
                File.WriteAllLines("settings.txt", lines);
            } else if (!(String.IsNullOrEmpty(text)))
            {
                using (StreamWriter sw = new StreamWriter("settings.txt"))
                {
                    sw.WriteLine(text);
                }
            }
            
        }

        // Try to load the dependencies folder from settings file, if not present, highlight setup button
        public void LoadSettings()
        {
            try
            {
                using (StreamReader sr = new StreamReader("settings.txt"))
                {
                    string dep = sr.ReadLine();
                    SetupButton.BackColor = Color.FromName("Control");
                }
            }
            catch
            {
                SetupButton.BackColor = Color.Red;
            }
        }

        public void UpdateCommand()
        {
            testingbox.Text = GenerateCommand();
        }

        private void UpdateCommand(object sender, EventArgs e)
        {
            testingbox.Text = GenerateCommand();
        }
    }
}
