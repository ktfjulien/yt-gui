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

        public MainForm()
        {
            InitializeComponent();


        }

        private String GenerateCommand()
        {
            string command = "yt-dlp.exe";
            command += " " + LinkBox.Text;

            // Defining checkboxes that have textboxes next to them
            // General Section
            List<CheckBox> generalspecial = new List<CheckBox>() { DefaultSearchCheck, WaitForVideoCheck, CompatOptionsCheck, AliasCheck };

            List<TextBox> generalspecial2 = new List<TextBox>() { DefaultSearchBox, WaitForVideoBox, CompatOptionsBox, AliasBox };

            // Video Selection Section
            List<CheckBox> videospecial = new List<CheckBox>() { checkBox13, checkBox14, checkBox23, checkBox19, checkBox31, checkBox29, checkBox25 };

            List<TextBox> videospecial2 = new List<TextBox>() { textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };

            // Network Section
            List<CheckBox> networkspecial = new List<CheckBox>() { ProxyCheck, SocketTimeoutCheck, SourceAddressIPCheck };

            List<TextBox> networkspecial2 = new List<TextBox>() { ProxyTextBox, textBox1, textBox2 };

            // Georestriction Section
            List<CheckBox> geospecial = new List<CheckBox>() { checkBox8, checkBox9, checkBox10 };

            List<TextBox> geospecial2 = new List<TextBox>() { GeoVerificationProxyTextbox, textBox4, textBox5 };

            
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
            //disabling text boxes that are next to check boxes
            //DefaultSearchBox.Enabled = DefaultSearchCheck.Checked;
            //WaitForVideoBox.Enabled = WaitForVideoCheck.Checked;
            //CompatOptionsBox.Enabled = CompatOptionsCheck.Checked;
            //AliasBox.Enabled = AliasCheck.Checked;

            polars = new CheckBox[] { NoAbortCheck, FlatPlaylistCheck, LiveFromStartCheck, WaitForVideoCheck, MarkWatchedCheck, checkBox19, checkBox17, checkBox31 , checkBox26 };
            polars2 = new CheckBox[] { AbortCheck, NoFlatPlaylistCheck, NoLiveFromStartCheck, NoWaitForVideoCheck, NoMarkWatchedCheck, checkBox18, checkBox15, checkBox30 };

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

            testingbox.Text = GenerateCommand();
        }
    }
}