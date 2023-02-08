using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace yt_gui
{
    public partial class MainForm : Form
    {

        CheckBox[] polars;
        CheckBox[] polars2;
        List<CheckBox> generalspecial;
        List<TextBox> generalspecial2;
        List<CheckBox> videospecial;
        List<TextBox> videospecial2;
        List<CheckBox> networkspecial;
        List<TextBox> networkspecial2;
        List<CheckBox> geospecial;
        List<TextBox> geospecial2;

        public MainForm()
        {
            InitializeComponent();
        }

        private String GenerateCommand()
        {
            string command = "yt-dlp.exe";
            command += " " + LinkBox.Text;

            // Loop through all checkboxes in each Group Box. If the checkbox is checked, and it doesn't have a text box next to it, add the text to the command
            // If the checkbox has a text box attached, add the checkbox text + the contents of the textbox

            foreach (CheckBox y in GeneralGroupBox.Controls.OfType<CheckBox>() )
            {
                if (!(generalspecial.Contains(y)))
                {
                    if (y.Checked) { command += " " + y.Text; };
                } else
                {
                    if (y.Checked) { command += " " + y.Text + " " + generalspecial2[generalspecial.IndexOf(y)].Text; };
                }
                
            }

            foreach (CheckBox y in VideoSelectionGroupBox.Controls.OfType<CheckBox>())
            {
                if (!(videospecial.Contains(y)))
                {
                    if (y.Checked) { command += " " + y.Text; };
                }
                else
                {
                    if (y.Checked) { command += " " + y.Text + " " + videospecial2[videospecial.IndexOf(y)].Text; };
                }
            }

            foreach (CheckBox y in NetworkGroupBox.Controls.OfType<CheckBox>())
            {
                if (!(networkspecial.Contains(y)))
                {
                    if (y.Checked) { command += " " + y.Text; };
                }
                else
                {
                    if (y.Checked) { command += " " + y.Text + " " + networkspecial2[networkspecial.IndexOf(y)].Text; };
                }
            }

            foreach (CheckBox y in GeorestrictionGroupBox.Controls.OfType<CheckBox>())
            {
                if (!(geospecial.Contains(y)))
                {
                    if (y.Checked) { command += " " + y.Text; };
                }
                else
                {
                    if (y.Checked) { command += " " + y.Text + " " + geospecial2[geospecial.IndexOf(y)].Text; };
                }
            }

            return command;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            polars = new CheckBox[] { NoAbortCheck, FlatPlaylistCheck, LiveFromStartCheck, WaitForVideoCheck, MarkWatchedCheck, checkBox19, checkBox17, checkBox31, checkBox26 };
            polars2 = new CheckBox[] { AbortCheck, NoFlatPlaylistCheck, NoLiveFromStartCheck, NoWaitForVideoCheck, NoMarkWatchedCheck, checkBox18, checkBox15, checkBox30, checkBox24 };


            // Defining checkboxes that have textboxes next to them
            // General Section
            generalspecial = new List<CheckBox>() { DefaultSearchCheck, WaitForVideoCheck, CompatOptionsCheck, AliasCheck };

            generalspecial2 = new List<TextBox>() { DefaultSearchBox, WaitForVideoBox, CompatOptionsBox, AliasBox };

            // Video Selection Section
            videospecial = new List<CheckBox>() { checkBox13, checkBox14, checkBox23, checkBox19, checkBox31, checkBox29, checkBox25 };

            videospecial2 = new List<TextBox>() { textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };

            // Network Section
            networkspecial = new List<CheckBox>() { ProxyCheck, SocketTimeoutCheck, SourceAddressIPCheck };

            networkspecial2 = new List<TextBox>() { ProxyTextBox, textBox1, textBox2 };

            // Georestriction Section
            geospecial = new List<CheckBox>() { checkBox8, checkBox9, checkBox10 };

            geospecial2 = new List<TextBox>() { GeoVerificationProxyTextbox, textBox4, textBox5 };

            Functions.LoadSettings();
            
        }

        

        private void PolarClicked(object sender, EventArgs e)
        {
            try {
                polars2[Array.IndexOf(polars, sender)].Checked = false;
            } catch {
                polars[Array.IndexOf(polars2, sender)].Checked = false;
            }
            
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            //string ytdlp = @"C:\Users\Julien\Documents\GitHub\yt-gui\yt-gui\external stuff\yt-dlp.exe";
            //ProcessStartInfo cmd = new ProcessStartInfo(ytdlp);
            //cmd.Arguments = LinkBox.Text;
            //Process.Start(cmd);

            //testingbox.Text = GenerateCommand();

            //SaveDepPath();

            using (StreamReader sr = new StreamReader("settings.txt"))
            {
                string ytdlp = sr.ReadLine() + "\\yt-dlp.exe";
                ProcessStartInfo cmd = new ProcessStartInfo(ytdlp);
                cmd.Arguments = LinkBox.Text;
                Process.Start(cmd);
            }

        }



        private void SetupButton_Click(object sender, EventArgs e)
        {
            Form SetupForm = new SetupForm();
            SetupForm.ShowDialog();
            Functions.LoadSettings();
        }

        static void SaveDepPath(string path)
        {
            using (StreamWriter sw = new StreamWriter("settings.txt"))
            {
                sw.WriteLine("yoyoyoyo");
                sw.Close();
            }
        }
    }
}