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
            string ytdlp = @"C:\Users\Julien\Documents\GitHub\yt-gui\yt-gui\external stuff\yt-dlp.exe";
            ProcessStartInfo cmd = new ProcessStartInfo(ytdlp);
            cmd.Arguments = LinkBox.Text;
            Process.Start(cmd);
        }
    }
}