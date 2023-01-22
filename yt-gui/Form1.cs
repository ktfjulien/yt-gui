using System.Diagnostics;
using System.Runtime.InteropServices;

namespace yt_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String GenerateCommand()
        {
            string command = "yt-dlp.exe";
            command += " " + LinkBox.Text;

            //// GENERAL SECTION
            //if (ignoreerrorscheck.Checked) { command += " " + ignoreerrorscheck.Text; };
            //if (NoAbortCheck.Checked) { command += " " +  NoAbortCheck.Text; };
            //if (AbortCheck.Checked) { command += " " +  AbortCheck.Text; };
            //if (forcegenericextractorcheck.Checked) { command += " " +  forcegenericextractorcheck.Text; };
            //if (DefaultSearchCheck.Checked) { command += " " +  DefaultSearchCheck.Text; };
            //// TEXT BOX NEEDED
            //if (checkBox6.Checked) { command += " " +  checkBox6.Text; };
            //if (checkBox7.Checked) { command += " " +  checkBox7.Text; };
            //if (FlatPlaylistCheck.Checked) { command += " " +  FlatPlaylistCheck.Text; };
            //if (NoFlatPlaylistCheck.Checked) { command += " " +  NoFlatPlaylistCheck.Text; };
            //if (LiveFromStartCheck.Checked) { command += " " +  LiveFromStartCheck.Text; };
            //if (NoLiveFromStartCheck.Checked) { command += " " +  NoLiveFromStartCheck.Text; };
            //if (WaitForVideoCheck.Checked) { command += " " +  WaitForVideoCheck.Text; };
            //// TEXT BOX NEEDED
            //if (NoWaitForVideoCheck.Checked) { command += " " +  NoWaitForVideoCheck.Text; };
            //if (MarkWatchedCheck.Checked) { command += " " +  MarkWatchedCheck.Text; };
            //if (NoMarkWatchedCheck.Checked) { command += " " +  NoMarkWatchedCheck.Text; };
            //if (checkBox16.Checked) { command += " " +  checkBox16.Text; };
            //if (CompatOptionsCheck.Checked) { command += " " +  CompatOptionsCheck.Text; };
            //// TEXT BOX NEEDED
            //if (AliasCheck.Checked) { command += " " +  AliasCheck.Text; };
            //// TEXT BOX NEEDED

            //// VIDEO SELECTION SECTION
            //if (checkBox13.Checked) { command += " " +  checkBox13.Text; };
            //// TEXT BOX NEEDED
            //if (checkBox14.Checked) { command += " " +  checkBox14.Text; };
            //// TEXT BOX NEEDED
            //if (checkBox23.Checked) { command += " " +  checkBox23.Text; };
            //// TEXT BOX NEEDED
            //if (checkBox22.Checked) { command += " " +  checkBox22.Text; };
            //if (checkBox21.Checked) { command += " " +  checkBox21.Text; };
            //if (checkBox20.Checked) { command += " " +  checkBox20.Text; };
            //if (checkBox19.Checked) { command += " " +  checkBox19.Text; };
            //// TEXT BOX NEEDED
            //if (checkBox18.Checked) { command += " " +  checkBox18.Text; };
            //if (checkBox17.Checked) { command += " " +  checkBox17.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };
            //if (REPLACETHIS.Checked) { command += " " +  ignoreerrorscheck.Text; };


            //foreach (CheckBox y in GeneralGroupBox.Controls)
            //{
            //    if (y.Checked) { command += " " + y.Text; };
            //}

            foreach (var y in GeneralGroupBox.Controls.OfType<CheckBox>() ) 
            {
                if (y.Checked) { command += " " + y.Text; };
            }

            foreach (var y in VideoSelectionGroupBox.Controls.OfType<CheckBox>())
            {
                if (y.Checked) { command += " " + y.Text; };
            }


            return command;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disabling text boxes that are next to check boxes
            DefaultSearchBox.Enabled = DefaultSearchCheck.Checked;
            WaitForVideoBox.Enabled = WaitForVideoCheck.Checked;
            CompatOptionsBox.Enabled = CompatOptionsCheck.Checked;
            AliasBox.Enabled = AliasCheck.Checked;
        }

        private void DefaultSearchCheck_CheckedChanged(object sender, EventArgs e)
        {
            DefaultSearchBox.Enabled = DefaultSearchCheck.Checked;
        }

        private void WaitForVideoCheck_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CompatOptionsCheck_CheckedChanged(object sender, EventArgs e)
        {
            CompatOptionsBox.Enabled = CompatOptionsCheck.Checked;
        }

        private void AliasCheck_CheckedChanged(object sender, EventArgs e)
        {
            AliasBox.Enabled = AliasCheck.Checked;
        }

        private void NoAbortCheck_Click(object sender, EventArgs e)
        {
            AbortCheck.Checked = false;
        }

        private void AbortCheck_Click(object sender, EventArgs e)
        {
            NoAbortCheck.Checked = false;
        }

        private void FlatPlaylistCheck_Click(object sender, EventArgs e)
        {
            NoFlatPlaylistCheck.Checked = false;
        }

        private void NoFlatPlaylistCheck_Click(object sender, EventArgs e)
        {
            FlatPlaylistCheck.Checked = false;
        }

        private void LiveFromStartCheck_Click(object sender, EventArgs e)
        {
            NoLiveFromStartCheck.Checked = false;
        }

        private void NoLiveFromStartCheck_Click(object sender, EventArgs e)
        {
            LiveFromStartCheck.Checked = false;
        }

        private void WaitForVideoCheck_Click(object sender, EventArgs e)
        {
            WaitForVideoBox.Enabled = WaitForVideoCheck.Checked;
            NoWaitForVideoCheck.Checked = false;
        }

        private void NoWaitForVideoCheck_Click(object sender, EventArgs e)
        {
            WaitForVideoBox.Enabled = false;
            WaitForVideoCheck.Checked = WaitForVideoBox.Enabled;
        }

        private void MarkWatchedCheck_Click(object sender, EventArgs e)
        {
            NoMarkWatchedCheck.Checked = false;
        }

        private void NoMarkWatchedCheck_Click(object sender, EventArgs e)
        {
            MarkWatchedCheck.Checked = false;
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