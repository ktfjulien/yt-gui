using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Configuration;

namespace yt_gui
{
    public partial class MainForm : Form
    {

        //CheckBox[] polars;
        //CheckBox[] polars2;
        Control[] ts;
        //CheckBox[,] polars3;
        //Control[] temp;
        private IConfigurationRoot _configuration;
        string dependencylocation;
        private string[,] test = new string[10, 10];
        Dictionary<string, string[]> p = new Dictionary<string, string[]>();

        public MainForm()
        {
            InitializeComponent();
            ts = new Control[] { DefaultSearchCheck, DefaultSearchBox, WaitForVideoCheck, WaitForVideoBox, CompatOptionsCheck, CompatOptionsBox, AliasCheck, AliasBox,
            PlaylistItemsCheck, PlaylistItemsBox, MinFileSizeCheck, MinFileSizeBox, MaxFileSizeCheck, MaxFileSizeBox, MatchFiltersCheck, MatchFiltersBox, DownloadArchiveCheck, DownloadArchiveBox, MaxDownloadsCheck, MaxDownloadsBox, SkipPlaylistAfterErrorsCheck, SkipPlaylistAfterErrorsBox,
            ProxyCheck, ProxyTextBox, SocketTimeoutCheck, SocketTimeoutBox, SourceAddressIPCheck, SourceAddressBox, GeoVerificationProxyTextCheck, GeoVerificationProxyBox, GeoBypassCountryCheck, GeoBypassCountryBox,
            GeoBypassIPBlockCheck, GeoBypassIPBlockBox};
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //OLD CODE FOR PUTTINGS PRESETS IN 2 DIMENSIONAL ARRAY
            // Initialize the configuration by reading the JSON file
            //var builder = new ConfigurationBuilder()
            //    .AddJsonFile("config.json", optional: true, reloadOnChange: true);
            //_configuration = builder.Build();
            //IConfigurationSection presets = _configuration.GetSection("Presets");
            //var presetsSection = _configuration.GetSection("Presets");

            //if (presetsSection != null)
            //{
            //    int i = 0;

            //    foreach (var preset in presetsSection.GetChildren())
            //    {
            //        // Get the key of the JSON array
            //        string key = preset.Key;

            //        // Place the key in the first dimension of 'test'
            //        test[i, 0] = key;

            //        // Get the contents of the JSON array
            //        var presetArray = preset.GetChildren();

            //        int j = 1;

            //        // Place the contents in the second dimension of 'test'
            //        foreach (var value in presetArray)
            //        {
            //            test[i, j++] = value.Value;
            //        }

            //        i++;
            //    }

            //NEW CODE FOR PUTTING PRESETS IN DICTIONARY
            var builder = new ConfigurationBuilder()
                .AddJsonFile("config.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
            var presetsSection = _configuration.GetSection("Presets");

            if (presetsSection != null)
            {
                foreach (var preset in presetsSection.GetChildren())
                {
                    string[] tempvals = { };

                    // Get the key of the JSON array
                    string key = preset.GetChildren().First().Value;

                    // Get the contents of the JSON array
                    var presetArray = preset.GetChildren();

                    // Place the contents in the second dimension of 'test'
                    foreach (var value in presetArray)
                    {
                        tempvals.Append(value.Value);
                        string t = "";

                    }
                    p.Add(key, tempvals);
                }
            }


                //LoadSettings();
                ReadOrCreateConfig();

        }


        
        


        public String GenerateCommand()
        {
            string command = "yt-dlp.exe";
            command += " " + LinkBox.Text;

            foreach (TabPage t in MainTabControl.Controls.OfType<TabPage>())
            {
                foreach (GroupBox g in t.Controls.OfType<GroupBox>())
                {
                    foreach (CheckBox c in g.Controls.OfType<CheckBox>())
                    {
                        if (ts.Contains(c))
                        {
                            if (c.Checked)
                            {
                                command += " " + c.Text + " " + ts[Array.IndexOf(ts, c) + 1].Text;
                            }
                        }
                    }
                }

            }

            return command;
        }

        private void SpecialClicked(object sender, EventArgs e)
        {

            ts[Array.IndexOf(ts, sender) + 1].Enabled ^= true;
            UpdateCommand(sender, e);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string ytdlp = "C:\\Users\\Julien\\Music\\app\\yt-dlp.exe";
            ProcessStartInfo cmd = new ProcessStartInfo(ytdlp);
            cmd.Arguments = LinkBox.Text;
            Process.Start(cmd);
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            Form SetupForm = new SetupForm();
            SetupForm.ShowDialog();
            LoadSettings();
        }

        private void LinkBox_TextChanged(object sender, EventArgs e)
        {
            testingbox.Text = GenerateCommand();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(testingbox.Text);
        }
    }
}