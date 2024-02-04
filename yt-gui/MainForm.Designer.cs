namespace yt_gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LinkLabel = new Label();
            DownloadButton = new Button();
            LinkBox = new TextBox();
            GeneralGroupBox = new GroupBox();
            AliasBox = new TextBox();
            AliasCheck = new CheckBox();
            CompatOptionsBox = new TextBox();
            CompatOptionsCheck = new CheckBox();
            NoColorsCheck = new CheckBox();
            NoMarkWatchedCheck = new CheckBox();
            MarkWatchedCheck = new CheckBox();
            NoWaitForVideoCheck = new CheckBox();
            WaitForVideoBox = new TextBox();
            WaitForVideoCheck = new CheckBox();
            NoLiveFromStartCheck = new CheckBox();
            LiveFromStartCheck = new CheckBox();
            NoFlatPlaylistCheck = new CheckBox();
            FlatPlaylistCheck = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            DefaultSearchBox = new TextBox();
            DefaultSearchCheck = new CheckBox();
            forcegenericextractorcheck = new CheckBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AbortCheck = new CheckBox();
            NoAbortCheck = new CheckBox();
            ignoreerrorscheck = new CheckBox();
            Update = new Button();
            VersionButton = new Button();
            HelpButton = new Button();
            NetworkGroupBox = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            SourceAddressBox = new TextBox();
            SourceAddressIPCheck = new CheckBox();
            SocketTimeoutBox = new TextBox();
            SocketTimeoutCheck = new CheckBox();
            ProxyTextBox = new TextBox();
            ProxyCheck = new CheckBox();
            GeorestrictionGroupBox = new GroupBox();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            GeoBypassIPBlockBox = new TextBox();
            GeoBypassIPBlockCheck = new CheckBox();
            GeoBypassCountryBox = new TextBox();
            GeoBypassCountryCheck = new CheckBox();
            GeoVerificationProxyBox = new TextBox();
            GeoVerificationProxyTextCheck = new CheckBox();
            MainTabControl = new TabControl();
            Page1 = new TabPage();
            VideoSelectionGroupBox = new GroupBox();
            SkipPlaylistAfterErrorsBox = new TextBox();
            MaxDownloadsBox = new TextBox();
            DownloadArchiveBox = new TextBox();
            MatchFiltersBox = new TextBox();
            MaxFileSizeBox = new TextBox();
            MinFileSizeBox = new TextBox();
            PlaylistItemsBox = new TextBox();
            AgeLimitCheck = new CheckBox();
            DownloadArchiveCheck = new CheckBox();
            NoDownloadArchiveCheck = new CheckBox();
            MaxDownloadsCheck = new CheckBox();
            BreakOnExistingCheck = new CheckBox();
            BreakOnRejectCheck = new CheckBox();
            BreakPerInputCheck = new CheckBox();
            SkipPlaylistAfterErrorsCheck = new CheckBox();
            NoBreakPerInputCheck = new CheckBox();
            MaxFileSizeCheck = new CheckBox();
            DateCheck = new CheckBox();
            DateBeforeCheck = new CheckBox();
            DateAfterCheck = new CheckBox();
            MatchFiltersCheck = new CheckBox();
            NoMatchFiltersCheck = new CheckBox();
            NoPlaylistCheck = new CheckBox();
            YesPlaylistCheck = new CheckBox();
            MinFileSizeCheck = new CheckBox();
            PlaylistItemsCheck = new CheckBox();
            Page2 = new TabPage();
            DownloadGroupBox = new GroupBox();
            testingbox = new TextBox();
            SetupButton = new Button();
            CopyButton = new Button();
            PresetsListBox = new ListBox();
            PresetsLabel = new Label();
            SavePreset = new Button();
            DeletePreset = new Button();
            GeneralGroupBox.SuspendLayout();
            NetworkGroupBox.SuspendLayout();
            GeorestrictionGroupBox.SuspendLayout();
            MainTabControl.SuspendLayout();
            Page1.SuspendLayout();
            VideoSelectionGroupBox.SuspendLayout();
            Page2.SuspendLayout();
            SuspendLayout();
            // 
            // LinkLabel
            // 
            LinkLabel.AutoSize = true;
            LinkLabel.Location = new Point(23, 15);
            LinkLabel.Name = "LinkLabel";
            LinkLabel.Size = new Size(32, 15);
            LinkLabel.TabIndex = 0;
            LinkLabel.Text = "Link:";
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(427, 750);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(90, 23);
            DownloadButton.TabIndex = 2;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // LinkBox
            // 
            LinkBox.Location = new Point(61, 12);
            LinkBox.Name = "LinkBox";
            LinkBox.Size = new Size(740, 23);
            LinkBox.TabIndex = 3;
            LinkBox.TextChanged += LinkBox_TextChanged;
            // 
            // GeneralGroupBox
            // 
            GeneralGroupBox.BackColor = SystemColors.Control;
            GeneralGroupBox.Controls.Add(AliasBox);
            GeneralGroupBox.Controls.Add(AliasCheck);
            GeneralGroupBox.Controls.Add(CompatOptionsBox);
            GeneralGroupBox.Controls.Add(CompatOptionsCheck);
            GeneralGroupBox.Controls.Add(NoColorsCheck);
            GeneralGroupBox.Controls.Add(NoMarkWatchedCheck);
            GeneralGroupBox.Controls.Add(MarkWatchedCheck);
            GeneralGroupBox.Controls.Add(NoWaitForVideoCheck);
            GeneralGroupBox.Controls.Add(WaitForVideoBox);
            GeneralGroupBox.Controls.Add(WaitForVideoCheck);
            GeneralGroupBox.Controls.Add(NoLiveFromStartCheck);
            GeneralGroupBox.Controls.Add(LiveFromStartCheck);
            GeneralGroupBox.Controls.Add(NoFlatPlaylistCheck);
            GeneralGroupBox.Controls.Add(FlatPlaylistCheck);
            GeneralGroupBox.Controls.Add(checkBox7);
            GeneralGroupBox.Controls.Add(checkBox6);
            GeneralGroupBox.Controls.Add(DefaultSearchBox);
            GeneralGroupBox.Controls.Add(DefaultSearchCheck);
            GeneralGroupBox.Controls.Add(forcegenericextractorcheck);
            GeneralGroupBox.Controls.Add(button3);
            GeneralGroupBox.Controls.Add(button2);
            GeneralGroupBox.Controls.Add(button1);
            GeneralGroupBox.Controls.Add(AbortCheck);
            GeneralGroupBox.Controls.Add(NoAbortCheck);
            GeneralGroupBox.Controls.Add(ignoreerrorscheck);
            GeneralGroupBox.Controls.Add(Update);
            GeneralGroupBox.Controls.Add(VersionButton);
            GeneralGroupBox.Controls.Add(HelpButton);
            GeneralGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GeneralGroupBox.ForeColor = SystemColors.ControlText;
            GeneralGroupBox.Location = new Point(6, 6);
            GeneralGroupBox.Name = "GeneralGroupBox";
            GeneralGroupBox.Size = new Size(386, 663);
            GeneralGroupBox.TabIndex = 12;
            GeneralGroupBox.TabStop = false;
            GeneralGroupBox.Text = "General";
            // 
            // AliasBox
            // 
            AliasBox.Enabled = false;
            AliasBox.Location = new Point(76, 617);
            AliasBox.Name = "AliasBox";
            AliasBox.Size = new Size(241, 23);
            AliasBox.TabIndex = 40;
            AliasBox.TextChanged += UpdateCommand;
            // 
            // AliasCheck
            // 
            AliasCheck.AutoSize = true;
            AliasCheck.Location = new Point(8, 621);
            AliasCheck.Name = "AliasCheck";
            AliasCheck.Size = new Size(59, 19);
            AliasCheck.TabIndex = 39;
            AliasCheck.Text = "--alias";
            AliasCheck.UseVisualStyleBackColor = true;
            AliasCheck.Click += SpecialClicked;
            // 
            // CompatOptionsBox
            // 
            CompatOptionsBox.Enabled = false;
            CompatOptionsBox.Location = new Point(139, 592);
            CompatOptionsBox.Name = "CompatOptionsBox";
            CompatOptionsBox.Size = new Size(241, 23);
            CompatOptionsBox.TabIndex = 38;
            CompatOptionsBox.TextChanged += UpdateCommand;
            // 
            // CompatOptionsCheck
            // 
            CompatOptionsCheck.AutoSize = true;
            CompatOptionsCheck.Location = new Point(8, 596);
            CompatOptionsCheck.Name = "CompatOptionsCheck";
            CompatOptionsCheck.Size = new Size(122, 19);
            CompatOptionsCheck.TabIndex = 37;
            CompatOptionsCheck.Text = "--compat-options";
            CompatOptionsCheck.UseVisualStyleBackColor = true;
            CompatOptionsCheck.Click += SpecialClicked;
            // 
            // NoColorsCheck
            // 
            NoColorsCheck.AutoSize = true;
            NoColorsCheck.Location = new Point(8, 571);
            NoColorsCheck.Name = "NoColorsCheck";
            NoColorsCheck.Size = new Size(87, 19);
            NoColorsCheck.TabIndex = 36;
            NoColorsCheck.Text = "--no-colors";
            NoColorsCheck.UseVisualStyleBackColor = true;
            // 
            // NoMarkWatchedCheck
            // 
            NoMarkWatchedCheck.AutoSize = true;
            NoMarkWatchedCheck.Location = new Point(8, 546);
            NoMarkWatchedCheck.Name = "NoMarkWatchedCheck";
            NoMarkWatchedCheck.Size = new Size(132, 19);
            NoMarkWatchedCheck.TabIndex = 35;
            NoMarkWatchedCheck.Text = "--no-mark-watched";
            NoMarkWatchedCheck.UseVisualStyleBackColor = true;
            // 
            // MarkWatchedCheck
            // 
            MarkWatchedCheck.AutoSize = true;
            MarkWatchedCheck.Location = new Point(8, 521);
            MarkWatchedCheck.Name = "MarkWatchedCheck";
            MarkWatchedCheck.Size = new Size(113, 19);
            MarkWatchedCheck.TabIndex = 34;
            MarkWatchedCheck.Text = "--mark-watched";
            MarkWatchedCheck.UseVisualStyleBackColor = true;
            // 
            // NoWaitForVideoCheck
            // 
            NoWaitForVideoCheck.AutoSize = true;
            NoWaitForVideoCheck.Location = new Point(8, 496);
            NoWaitForVideoCheck.Name = "NoWaitForVideoCheck";
            NoWaitForVideoCheck.Size = new Size(131, 19);
            NoWaitForVideoCheck.TabIndex = 33;
            NoWaitForVideoCheck.Text = "--no-wait-for-video";
            NoWaitForVideoCheck.UseVisualStyleBackColor = true;
            // 
            // WaitForVideoBox
            // 
            WaitForVideoBox.Enabled = false;
            WaitForVideoBox.Location = new Point(129, 467);
            WaitForVideoBox.Name = "WaitForVideoBox";
            WaitForVideoBox.Size = new Size(241, 23);
            WaitForVideoBox.TabIndex = 32;
            WaitForVideoBox.TextChanged += UpdateCommand;
            // 
            // WaitForVideoCheck
            // 
            WaitForVideoCheck.AutoSize = true;
            WaitForVideoCheck.Location = new Point(8, 471);
            WaitForVideoCheck.Name = "WaitForVideoCheck";
            WaitForVideoCheck.Size = new Size(112, 19);
            WaitForVideoCheck.TabIndex = 31;
            WaitForVideoCheck.Text = "--wait-for-video";
            WaitForVideoCheck.UseVisualStyleBackColor = true;
            WaitForVideoCheck.CheckedChanged += SpecialClicked;
            // 
            // NoLiveFromStartCheck
            // 
            NoLiveFromStartCheck.AutoSize = true;
            NoLiveFromStartCheck.Location = new Point(8, 446);
            NoLiveFromStartCheck.Name = "NoLiveFromStartCheck";
            NoLiveFromStartCheck.Size = new Size(132, 19);
            NoLiveFromStartCheck.TabIndex = 30;
            NoLiveFromStartCheck.Text = "--no-live-from-start";
            NoLiveFromStartCheck.UseVisualStyleBackColor = true;
            // 
            // LiveFromStartCheck
            // 
            LiveFromStartCheck.AutoSize = true;
            LiveFromStartCheck.Location = new Point(8, 421);
            LiveFromStartCheck.Name = "LiveFromStartCheck";
            LiveFromStartCheck.Size = new Size(113, 19);
            LiveFromStartCheck.TabIndex = 29;
            LiveFromStartCheck.Text = "--live-from-start";
            LiveFromStartCheck.UseVisualStyleBackColor = true;
            // 
            // NoFlatPlaylistCheck
            // 
            NoFlatPlaylistCheck.AutoSize = true;
            NoFlatPlaylistCheck.Location = new Point(8, 396);
            NoFlatPlaylistCheck.Name = "NoFlatPlaylistCheck";
            NoFlatPlaylistCheck.Size = new Size(114, 19);
            NoFlatPlaylistCheck.TabIndex = 28;
            NoFlatPlaylistCheck.Text = "--no-flat-playlist";
            NoFlatPlaylistCheck.UseVisualStyleBackColor = true;
            // 
            // FlatPlaylistCheck
            // 
            FlatPlaylistCheck.AutoSize = true;
            FlatPlaylistCheck.Location = new Point(8, 371);
            FlatPlaylistCheck.Name = "FlatPlaylistCheck";
            FlatPlaylistCheck.Size = new Size(95, 19);
            FlatPlaylistCheck.TabIndex = 27;
            FlatPlaylistCheck.Text = "--flat-playlist";
            FlatPlaylistCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(8, 346);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(142, 19);
            checkBox7.TabIndex = 26;
            checkBox7.Text = "--no-config-locations";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(8, 321);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(109, 19);
            checkBox6.TabIndex = 25;
            checkBox6.Text = "--ignore-config";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // DefaultSearchBox
            // 
            DefaultSearchBox.Enabled = false;
            DefaultSearchBox.Location = new Point(130, 294);
            DefaultSearchBox.Name = "DefaultSearchBox";
            DefaultSearchBox.Size = new Size(241, 23);
            DefaultSearchBox.TabIndex = 24;
            DefaultSearchBox.TextChanged += UpdateCommand;
            // 
            // DefaultSearchCheck
            // 
            DefaultSearchCheck.AutoSize = true;
            DefaultSearchCheck.Location = new Point(8, 296);
            DefaultSearchCheck.Name = "DefaultSearchCheck";
            DefaultSearchCheck.Size = new Size(112, 19);
            DefaultSearchCheck.TabIndex = 23;
            DefaultSearchCheck.Text = "--default-search";
            DefaultSearchCheck.UseVisualStyleBackColor = true;
            DefaultSearchCheck.Click += SpecialClicked;
            // 
            // forcegenericextractorcheck
            // 
            forcegenericextractorcheck.AutoSize = true;
            forcegenericextractorcheck.Location = new Point(8, 271);
            forcegenericextractorcheck.Name = "forcegenericextractorcheck";
            forcegenericextractorcheck.Size = new Size(162, 19);
            forcegenericextractorcheck.TabIndex = 22;
            forcegenericextractorcheck.Text = "--force-generic-extractor ";
            forcegenericextractorcheck.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(8, 242);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 21;
            button3.Text = "Extractor Descriptions";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(8, 213);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 20;
            button2.Text = "List Extractors";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(8, 184);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 19;
            button1.Text = "Dump User Agent";
            button1.UseVisualStyleBackColor = true;
            // 
            // AbortCheck
            // 
            AbortCheck.AutoSize = true;
            AbortCheck.Location = new Point(8, 159);
            AbortCheck.Name = "AbortCheck";
            AbortCheck.Size = new Size(113, 19);
            AbortCheck.TabIndex = 18;
            AbortCheck.Text = "--abort-on-error";
            AbortCheck.UseVisualStyleBackColor = true;
            // 
            // NoAbortCheck
            // 
            NoAbortCheck.AutoSize = true;
            NoAbortCheck.Location = new Point(8, 134);
            NoAbortCheck.Name = "NoAbortCheck";
            NoAbortCheck.Size = new Size(132, 19);
            NoAbortCheck.TabIndex = 17;
            NoAbortCheck.Text = "--no-abort-on-error";
            NoAbortCheck.UseVisualStyleBackColor = true;
            // 
            // ignoreerrorscheck
            // 
            ignoreerrorscheck.AutoSize = true;
            ignoreerrorscheck.Location = new Point(8, 109);
            ignoreerrorscheck.Name = "ignoreerrorscheck";
            ignoreerrorscheck.Size = new Size(105, 19);
            ignoreerrorscheck.TabIndex = 16;
            ignoreerrorscheck.Text = "--ignore-errors";
            ignoreerrorscheck.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.Location = new Point(8, 80);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 15;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // VersionButton
            // 
            VersionButton.Location = new Point(8, 51);
            VersionButton.Name = "VersionButton";
            VersionButton.Size = new Size(75, 23);
            VersionButton.TabIndex = 14;
            VersionButton.Text = "Version";
            VersionButton.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(8, 22);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(75, 23);
            HelpButton.TabIndex = 13;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            // 
            // NetworkGroupBox
            // 
            NetworkGroupBox.BackColor = SystemColors.Control;
            NetworkGroupBox.Controls.Add(checkBox5);
            NetworkGroupBox.Controls.Add(checkBox3);
            NetworkGroupBox.Controls.Add(checkBox2);
            NetworkGroupBox.Controls.Add(SourceAddressBox);
            NetworkGroupBox.Controls.Add(SourceAddressIPCheck);
            NetworkGroupBox.Controls.Add(SocketTimeoutBox);
            NetworkGroupBox.Controls.Add(SocketTimeoutCheck);
            NetworkGroupBox.Controls.Add(ProxyTextBox);
            NetworkGroupBox.Controls.Add(ProxyCheck);
            NetworkGroupBox.Location = new Point(7, 6);
            NetworkGroupBox.Name = "NetworkGroupBox";
            NetworkGroupBox.Size = new Size(386, 186);
            NetworkGroupBox.TabIndex = 13;
            NetworkGroupBox.TabStop = false;
            NetworkGroupBox.Text = "Network";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(11, 157);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(116, 19);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "--enable-file-urls";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(11, 130);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(90, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "--force-ipv6";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(11, 103);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "--force-ipv4";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // SourceAddressBox
            // 
            SourceAddressBox.Enabled = false;
            SourceAddressBox.Location = new Point(134, 74);
            SourceAddressBox.Name = "SourceAddressBox";
            SourceAddressBox.Size = new Size(165, 23);
            SourceAddressBox.TabIndex = 5;
            // 
            // SourceAddressIPCheck
            // 
            SourceAddressIPCheck.AutoSize = true;
            SourceAddressIPCheck.Location = new Point(11, 76);
            SourceAddressIPCheck.Name = "SourceAddressIPCheck";
            SourceAddressIPCheck.Size = new Size(116, 19);
            SourceAddressIPCheck.TabIndex = 4;
            SourceAddressIPCheck.Text = "--source-address";
            SourceAddressIPCheck.UseVisualStyleBackColor = true;
            SourceAddressIPCheck.Click += SpecialClicked;
            // 
            // SocketTimeoutBox
            // 
            SocketTimeoutBox.Enabled = false;
            SocketTimeoutBox.Location = new Point(134, 47);
            SocketTimeoutBox.Name = "SocketTimeoutBox";
            SocketTimeoutBox.Size = new Size(165, 23);
            SocketTimeoutBox.TabIndex = 3;
            // 
            // SocketTimeoutCheck
            // 
            SocketTimeoutCheck.AutoSize = true;
            SocketTimeoutCheck.Location = new Point(11, 49);
            SocketTimeoutCheck.Name = "SocketTimeoutCheck";
            SocketTimeoutCheck.Size = new Size(117, 19);
            SocketTimeoutCheck.TabIndex = 2;
            SocketTimeoutCheck.Text = "--socket-timeout";
            SocketTimeoutCheck.UseVisualStyleBackColor = true;
            SocketTimeoutCheck.Click += SpecialClicked;
            // 
            // ProxyTextBox
            // 
            ProxyTextBox.Enabled = false;
            ProxyTextBox.Location = new Point(81, 20);
            ProxyTextBox.Name = "ProxyTextBox";
            ProxyTextBox.Size = new Size(165, 23);
            ProxyTextBox.TabIndex = 1;
            // 
            // ProxyCheck
            // 
            ProxyCheck.AutoSize = true;
            ProxyCheck.Location = new Point(11, 22);
            ProxyCheck.Name = "ProxyCheck";
            ProxyCheck.Size = new Size(66, 19);
            ProxyCheck.TabIndex = 0;
            ProxyCheck.Text = "--proxy";
            ProxyCheck.UseVisualStyleBackColor = true;
            ProxyCheck.Click += SpecialClicked;
            // 
            // GeorestrictionGroupBox
            // 
            GeorestrictionGroupBox.BackColor = SystemColors.Control;
            GeorestrictionGroupBox.Controls.Add(checkBox12);
            GeorestrictionGroupBox.Controls.Add(checkBox11);
            GeorestrictionGroupBox.Controls.Add(GeoBypassIPBlockBox);
            GeorestrictionGroupBox.Controls.Add(GeoBypassIPBlockCheck);
            GeorestrictionGroupBox.Controls.Add(GeoBypassCountryBox);
            GeorestrictionGroupBox.Controls.Add(GeoBypassCountryCheck);
            GeorestrictionGroupBox.Controls.Add(GeoVerificationProxyBox);
            GeorestrictionGroupBox.Controls.Add(GeoVerificationProxyTextCheck);
            GeorestrictionGroupBox.Location = new Point(7, 198);
            GeorestrictionGroupBox.Name = "GeorestrictionGroupBox";
            GeorestrictionGroupBox.Size = new Size(386, 161);
            GeorestrictionGroupBox.TabIndex = 14;
            GeorestrictionGroupBox.TabStop = false;
            GeorestrictionGroupBox.Text = "Geo-restriction";
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(11, 78);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(116, 19);
            checkBox12.TabIndex = 9;
            checkBox12.Text = "--no-geo-bypass";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(11, 51);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(97, 19);
            checkBox11.TabIndex = 8;
            checkBox11.Text = "--geo-bypass";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // GeoBypassIPBlockBox
            // 
            GeoBypassIPBlockBox.Enabled = false;
            GeoBypassIPBlockBox.Location = new Point(163, 130);
            GeoBypassIPBlockBox.Name = "GeoBypassIPBlockBox";
            GeoBypassIPBlockBox.Size = new Size(165, 23);
            GeoBypassIPBlockBox.TabIndex = 7;
            // 
            // GeoBypassIPBlockCheck
            // 
            GeoBypassIPBlockCheck.AutoSize = true;
            GeoBypassIPBlockCheck.Location = new Point(11, 132);
            GeoBypassIPBlockCheck.Name = "GeoBypassIPBlockCheck";
            GeoBypassIPBlockCheck.Size = new Size(146, 19);
            GeoBypassIPBlockCheck.TabIndex = 6;
            GeoBypassIPBlockCheck.Text = "--geo-bypass-ip-block";
            GeoBypassIPBlockCheck.UseVisualStyleBackColor = true;
            GeoBypassIPBlockCheck.Click += SpecialClicked;
            // 
            // GeoBypassCountryBox
            // 
            GeoBypassCountryBox.Enabled = false;
            GeoBypassCountryBox.Location = new Point(163, 103);
            GeoBypassCountryBox.Name = "GeoBypassCountryBox";
            GeoBypassCountryBox.Size = new Size(165, 23);
            GeoBypassCountryBox.TabIndex = 5;
            // 
            // GeoBypassCountryCheck
            // 
            GeoBypassCountryCheck.AutoSize = true;
            GeoBypassCountryCheck.Location = new Point(11, 105);
            GeoBypassCountryCheck.Name = "GeoBypassCountryCheck";
            GeoBypassCountryCheck.Size = new Size(143, 19);
            GeoBypassCountryCheck.TabIndex = 4;
            GeoBypassCountryCheck.Text = "--geo-bypass-country";
            GeoBypassCountryCheck.UseVisualStyleBackColor = true;
            GeoBypassCountryCheck.Click += SpecialClicked;
            // 
            // GeoVerificationProxyBox
            // 
            GeoVerificationProxyBox.Enabled = false;
            GeoVerificationProxyBox.Location = new Point(175, 22);
            GeoVerificationProxyBox.Name = "GeoVerificationProxyBox";
            GeoVerificationProxyBox.Size = new Size(165, 23);
            GeoVerificationProxyBox.TabIndex = 3;
            // 
            // GeoVerificationProxyTextCheck
            // 
            GeoVerificationProxyTextCheck.AutoSize = true;
            GeoVerificationProxyTextCheck.Location = new Point(11, 24);
            GeoVerificationProxyTextCheck.Name = "GeoVerificationProxyTextCheck";
            GeoVerificationProxyTextCheck.Size = new Size(155, 19);
            GeoVerificationProxyTextCheck.TabIndex = 2;
            GeoVerificationProxyTextCheck.Text = "--geo-verification-proxy";
            GeoVerificationProxyTextCheck.UseVisualStyleBackColor = true;
            GeoVerificationProxyTextCheck.Click += SpecialClicked;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(Page1);
            MainTabControl.Controls.Add(Page2);
            MainTabControl.Location = new Point(12, 41);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(801, 703);
            MainTabControl.TabIndex = 16;
            // 
            // Page1
            // 
            Page1.Controls.Add(VideoSelectionGroupBox);
            Page1.Controls.Add(GeneralGroupBox);
            Page1.Location = new Point(4, 24);
            Page1.Name = "Page1";
            Page1.Padding = new Padding(3);
            Page1.Size = new Size(793, 675);
            Page1.TabIndex = 0;
            Page1.Text = "Page 1";
            Page1.UseVisualStyleBackColor = true;
            // 
            // VideoSelectionGroupBox
            // 
            VideoSelectionGroupBox.BackColor = SystemColors.Control;
            VideoSelectionGroupBox.Controls.Add(SkipPlaylistAfterErrorsBox);
            VideoSelectionGroupBox.Controls.Add(MaxDownloadsBox);
            VideoSelectionGroupBox.Controls.Add(DownloadArchiveBox);
            VideoSelectionGroupBox.Controls.Add(MatchFiltersBox);
            VideoSelectionGroupBox.Controls.Add(MaxFileSizeBox);
            VideoSelectionGroupBox.Controls.Add(MinFileSizeBox);
            VideoSelectionGroupBox.Controls.Add(PlaylistItemsBox);
            VideoSelectionGroupBox.Controls.Add(AgeLimitCheck);
            VideoSelectionGroupBox.Controls.Add(DownloadArchiveCheck);
            VideoSelectionGroupBox.Controls.Add(NoDownloadArchiveCheck);
            VideoSelectionGroupBox.Controls.Add(MaxDownloadsCheck);
            VideoSelectionGroupBox.Controls.Add(BreakOnExistingCheck);
            VideoSelectionGroupBox.Controls.Add(BreakOnRejectCheck);
            VideoSelectionGroupBox.Controls.Add(BreakPerInputCheck);
            VideoSelectionGroupBox.Controls.Add(SkipPlaylistAfterErrorsCheck);
            VideoSelectionGroupBox.Controls.Add(NoBreakPerInputCheck);
            VideoSelectionGroupBox.Controls.Add(MaxFileSizeCheck);
            VideoSelectionGroupBox.Controls.Add(DateCheck);
            VideoSelectionGroupBox.Controls.Add(DateBeforeCheck);
            VideoSelectionGroupBox.Controls.Add(DateAfterCheck);
            VideoSelectionGroupBox.Controls.Add(MatchFiltersCheck);
            VideoSelectionGroupBox.Controls.Add(NoMatchFiltersCheck);
            VideoSelectionGroupBox.Controls.Add(NoPlaylistCheck);
            VideoSelectionGroupBox.Controls.Add(YesPlaylistCheck);
            VideoSelectionGroupBox.Controls.Add(MinFileSizeCheck);
            VideoSelectionGroupBox.Controls.Add(PlaylistItemsCheck);
            VideoSelectionGroupBox.Location = new Point(399, 9);
            VideoSelectionGroupBox.Name = "VideoSelectionGroupBox";
            VideoSelectionGroupBox.Size = new Size(386, 663);
            VideoSelectionGroupBox.TabIndex = 13;
            VideoSelectionGroupBox.TabStop = false;
            VideoSelectionGroupBox.Text = "Video Selection";
            // 
            // SkipPlaylistAfterErrorsBox
            // 
            SkipPlaylistAfterErrorsBox.Enabled = false;
            SkipPlaylistAfterErrorsBox.Location = new Point(178, 453);
            SkipPlaylistAfterErrorsBox.Name = "SkipPlaylistAfterErrorsBox";
            SkipPlaylistAfterErrorsBox.Size = new Size(165, 23);
            SkipPlaylistAfterErrorsBox.TabIndex = 25;
            SkipPlaylistAfterErrorsBox.TextChanged += UpdateCommand;
            // 
            // MaxDownloadsBox
            // 
            MaxDownloadsBox.Enabled = false;
            MaxDownloadsBox.Location = new Point(137, 333);
            MaxDownloadsBox.Name = "MaxDownloadsBox";
            MaxDownloadsBox.Size = new Size(165, 23);
            MaxDownloadsBox.TabIndex = 24;
            MaxDownloadsBox.TextChanged += UpdateCommand;
            // 
            // DownloadArchiveBox
            // 
            DownloadArchiveBox.Enabled = false;
            DownloadArchiveBox.Location = new Point(147, 285);
            DownloadArchiveBox.Name = "DownloadArchiveBox";
            DownloadArchiveBox.Size = new Size(165, 23);
            DownloadArchiveBox.TabIndex = 23;
            DownloadArchiveBox.TextChanged += UpdateCommand;
            // 
            // MatchFiltersBox
            // 
            MatchFiltersBox.Enabled = false;
            MatchFiltersBox.Location = new Point(122, 165);
            MatchFiltersBox.Name = "MatchFiltersBox";
            MatchFiltersBox.Size = new Size(165, 23);
            MatchFiltersBox.TabIndex = 22;
            MatchFiltersBox.TextChanged += UpdateCommand;
            // 
            // MaxFileSizeBox
            // 
            MaxFileSizeBox.Enabled = false;
            MaxFileSizeBox.Location = new Point(114, 76);
            MaxFileSizeBox.Name = "MaxFileSizeBox";
            MaxFileSizeBox.Size = new Size(165, 23);
            MaxFileSizeBox.TabIndex = 21;
            MaxFileSizeBox.TextChanged += UpdateCommand;
            // 
            // MinFileSizeBox
            // 
            MinFileSizeBox.Enabled = false;
            MinFileSizeBox.Location = new Point(122, 47);
            MinFileSizeBox.Name = "MinFileSizeBox";
            MinFileSizeBox.Size = new Size(165, 23);
            MinFileSizeBox.TabIndex = 20;
            MinFileSizeBox.TextChanged += UpdateCommand;
            // 
            // PlaylistItemsBox
            // 
            PlaylistItemsBox.Enabled = false;
            PlaylistItemsBox.Location = new Point(122, 21);
            PlaylistItemsBox.Name = "PlaylistItemsBox";
            PlaylistItemsBox.Size = new Size(165, 23);
            PlaylistItemsBox.TabIndex = 19;
            PlaylistItemsBox.TextChanged += UpdateCommand;
            // 
            // AgeLimitCheck
            // 
            AgeLimitCheck.AutoSize = true;
            AgeLimitCheck.Location = new Point(6, 263);
            AgeLimitCheck.Name = "AgeLimitCheck";
            AgeLimitCheck.Size = new Size(84, 19);
            AgeLimitCheck.TabIndex = 18;
            AgeLimitCheck.Text = "--age-limit";
            AgeLimitCheck.UseVisualStyleBackColor = true;
            // 
            // DownloadArchiveCheck
            // 
            DownloadArchiveCheck.AutoSize = true;
            DownloadArchiveCheck.Location = new Point(6, 287);
            DownloadArchiveCheck.Name = "DownloadArchiveCheck";
            DownloadArchiveCheck.Size = new Size(132, 19);
            DownloadArchiveCheck.TabIndex = 17;
            DownloadArchiveCheck.Text = "--download-archive";
            DownloadArchiveCheck.UseVisualStyleBackColor = true;
            DownloadArchiveCheck.Click += SpecialClicked;
            // 
            // NoDownloadArchiveCheck
            // 
            NoDownloadArchiveCheck.AutoSize = true;
            NoDownloadArchiveCheck.Location = new Point(6, 311);
            NoDownloadArchiveCheck.Name = "NoDownloadArchiveCheck";
            NoDownloadArchiveCheck.Size = new Size(151, 19);
            NoDownloadArchiveCheck.TabIndex = 16;
            NoDownloadArchiveCheck.Text = "--no-download-archive";
            NoDownloadArchiveCheck.UseVisualStyleBackColor = true;
            // 
            // MaxDownloadsCheck
            // 
            MaxDownloadsCheck.AutoSize = true;
            MaxDownloadsCheck.Location = new Point(6, 335);
            MaxDownloadsCheck.Name = "MaxDownloadsCheck";
            MaxDownloadsCheck.Size = new Size(122, 19);
            MaxDownloadsCheck.TabIndex = 15;
            MaxDownloadsCheck.Text = "--max-downloads";
            MaxDownloadsCheck.UseVisualStyleBackColor = true;
            MaxDownloadsCheck.Click += SpecialClicked;
            // 
            // BreakOnExistingCheck
            // 
            BreakOnExistingCheck.AutoSize = true;
            BreakOnExistingCheck.Location = new Point(6, 359);
            BreakOnExistingCheck.Name = "BreakOnExistingCheck";
            BreakOnExistingCheck.Size = new Size(130, 19);
            BreakOnExistingCheck.TabIndex = 14;
            BreakOnExistingCheck.Text = "--break-on-existing";
            BreakOnExistingCheck.UseVisualStyleBackColor = true;
            // 
            // BreakOnRejectCheck
            // 
            BreakOnRejectCheck.AutoSize = true;
            BreakOnRejectCheck.Location = new Point(6, 383);
            BreakOnRejectCheck.Name = "BreakOnRejectCheck";
            BreakOnRejectCheck.Size = new Size(118, 19);
            BreakOnRejectCheck.TabIndex = 13;
            BreakOnRejectCheck.Text = "--break-on-reject";
            BreakOnRejectCheck.UseVisualStyleBackColor = true;
            // 
            // BreakPerInputCheck
            // 
            BreakPerInputCheck.AutoSize = true;
            BreakPerInputCheck.Location = new Point(6, 407);
            BreakPerInputCheck.Name = "BreakPerInputCheck";
            BreakPerInputCheck.Size = new Size(120, 19);
            BreakPerInputCheck.TabIndex = 12;
            BreakPerInputCheck.Text = "--break-per-input";
            BreakPerInputCheck.UseVisualStyleBackColor = true;
            // 
            // SkipPlaylistAfterErrorsCheck
            // 
            SkipPlaylistAfterErrorsCheck.AutoSize = true;
            SkipPlaylistAfterErrorsCheck.Location = new Point(6, 455);
            SkipPlaylistAfterErrorsCheck.Name = "SkipPlaylistAfterErrorsCheck";
            SkipPlaylistAfterErrorsCheck.Size = new Size(163, 19);
            SkipPlaylistAfterErrorsCheck.TabIndex = 11;
            SkipPlaylistAfterErrorsCheck.Text = "--skip-playlist-after-errors";
            SkipPlaylistAfterErrorsCheck.UseVisualStyleBackColor = true;
            SkipPlaylistAfterErrorsCheck.Click += SpecialClicked;
            // 
            // NoBreakPerInputCheck
            // 
            NoBreakPerInputCheck.AutoSize = true;
            NoBreakPerInputCheck.Location = new Point(6, 431);
            NoBreakPerInputCheck.Name = "NoBreakPerInputCheck";
            NoBreakPerInputCheck.Size = new Size(139, 19);
            NoBreakPerInputCheck.TabIndex = 10;
            NoBreakPerInputCheck.Text = "--no-break-per-input";
            NoBreakPerInputCheck.UseVisualStyleBackColor = true;
            // 
            // MaxFileSizeCheck
            // 
            MaxFileSizeCheck.AutoSize = true;
            MaxFileSizeCheck.Location = new Point(6, 71);
            MaxFileSizeCheck.Name = "MaxFileSizeCheck";
            MaxFileSizeCheck.Size = new Size(99, 19);
            MaxFileSizeCheck.TabIndex = 9;
            MaxFileSizeCheck.Text = "--max-filesize";
            MaxFileSizeCheck.UseVisualStyleBackColor = true;
            MaxFileSizeCheck.Click += SpecialClicked;
            // 
            // DateCheck
            // 
            DateCheck.AutoSize = true;
            DateCheck.Location = new Point(6, 95);
            DateCheck.Name = "DateCheck";
            DateCheck.Size = new Size(62, 19);
            DateCheck.TabIndex = 8;
            DateCheck.Text = "--date:";
            DateCheck.UseVisualStyleBackColor = true;
            // 
            // DateBeforeCheck
            // 
            DateBeforeCheck.AutoSize = true;
            DateBeforeCheck.Location = new Point(6, 119);
            DateBeforeCheck.Name = "DateBeforeCheck";
            DateBeforeCheck.Size = new Size(96, 19);
            DateBeforeCheck.TabIndex = 7;
            DateBeforeCheck.Text = "--datebefore:";
            DateBeforeCheck.UseVisualStyleBackColor = true;
            // 
            // DateAfterCheck
            // 
            DateAfterCheck.AutoSize = true;
            DateAfterCheck.Location = new Point(6, 143);
            DateAfterCheck.Name = "DateAfterCheck";
            DateAfterCheck.Size = new Size(86, 19);
            DateAfterCheck.TabIndex = 6;
            DateAfterCheck.Text = "--dateafter:";
            DateAfterCheck.UseVisualStyleBackColor = true;
            // 
            // MatchFiltersCheck
            // 
            MatchFiltersCheck.AutoSize = true;
            MatchFiltersCheck.Location = new Point(6, 167);
            MatchFiltersCheck.Name = "MatchFiltersCheck";
            MatchFiltersCheck.Size = new Size(107, 19);
            MatchFiltersCheck.TabIndex = 5;
            MatchFiltersCheck.Text = "--match-filters:";
            MatchFiltersCheck.UseVisualStyleBackColor = true;
            MatchFiltersCheck.Click += SpecialClicked;
            // 
            // NoMatchFiltersCheck
            // 
            NoMatchFiltersCheck.AutoSize = true;
            NoMatchFiltersCheck.Location = new Point(6, 191);
            NoMatchFiltersCheck.Name = "NoMatchFiltersCheck";
            NoMatchFiltersCheck.Size = new Size(118, 19);
            NoMatchFiltersCheck.TabIndex = 4;
            NoMatchFiltersCheck.Text = "--no-match-filter";
            NoMatchFiltersCheck.UseVisualStyleBackColor = true;
            // 
            // NoPlaylistCheck
            // 
            NoPlaylistCheck.AutoSize = true;
            NoPlaylistCheck.Location = new Point(6, 215);
            NoPlaylistCheck.Name = "NoPlaylistCheck";
            NoPlaylistCheck.Size = new Size(92, 19);
            NoPlaylistCheck.TabIndex = 3;
            NoPlaylistCheck.Text = "--no-playlist";
            NoPlaylistCheck.UseVisualStyleBackColor = true;
            // 
            // YesPlaylistCheck
            // 
            YesPlaylistCheck.AutoSize = true;
            YesPlaylistCheck.Location = new Point(6, 239);
            YesPlaylistCheck.Name = "YesPlaylistCheck";
            YesPlaylistCheck.Size = new Size(95, 19);
            YesPlaylistCheck.TabIndex = 2;
            YesPlaylistCheck.Text = "--yes-playlist";
            YesPlaylistCheck.UseVisualStyleBackColor = true;
            // 
            // MinFileSizeCheck
            // 
            MinFileSizeCheck.AutoSize = true;
            MinFileSizeCheck.Location = new Point(6, 47);
            MinFileSizeCheck.Name = "MinFileSizeCheck";
            MinFileSizeCheck.Size = new Size(97, 19);
            MinFileSizeCheck.TabIndex = 1;
            MinFileSizeCheck.Text = "--min-filesize";
            MinFileSizeCheck.UseVisualStyleBackColor = true;
            MinFileSizeCheck.Click += SpecialClicked;
            // 
            // PlaylistItemsCheck
            // 
            PlaylistItemsCheck.AutoSize = true;
            PlaylistItemsCheck.Location = new Point(6, 23);
            PlaylistItemsCheck.Name = "PlaylistItemsCheck";
            PlaylistItemsCheck.Size = new Size(107, 19);
            PlaylistItemsCheck.TabIndex = 0;
            PlaylistItemsCheck.Text = "--playlist-items";
            PlaylistItemsCheck.UseVisualStyleBackColor = true;
            PlaylistItemsCheck.Click += SpecialClicked;
            // 
            // Page2
            // 
            Page2.Controls.Add(DownloadGroupBox);
            Page2.Controls.Add(NetworkGroupBox);
            Page2.Controls.Add(GeorestrictionGroupBox);
            Page2.Location = new Point(4, 24);
            Page2.Name = "Page2";
            Page2.Padding = new Padding(3);
            Page2.Size = new Size(793, 675);
            Page2.TabIndex = 1;
            Page2.Text = "Page 2";
            Page2.UseVisualStyleBackColor = true;
            // 
            // DownloadGroupBox
            // 
            DownloadGroupBox.Location = new Point(399, 3);
            DownloadGroupBox.Name = "DownloadGroupBox";
            DownloadGroupBox.Size = new Size(391, 666);
            DownloadGroupBox.TabIndex = 9;
            DownloadGroupBox.TabStop = false;
            DownloadGroupBox.Text = "Download";
            // 
            // testingbox
            // 
            testingbox.Location = new Point(61, 777);
            testingbox.Name = "testingbox";
            testingbox.ScrollBars = ScrollBars.Both;
            testingbox.Size = new Size(725, 23);
            testingbox.TabIndex = 17;
            // 
            // SetupButton
            // 
            SetupButton.Location = new Point(265, 751);
            SetupButton.Margin = new Padding(2, 1, 2, 1);
            SetupButton.Name = "SetupButton";
            SetupButton.Size = new Size(81, 22);
            SetupButton.TabIndex = 18;
            SetupButton.Text = "Setup";
            SetupButton.UseVisualStyleBackColor = true;
            SetupButton.Click += SetupButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Location = new Point(602, 751);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(75, 23);
            CopyButton.TabIndex = 19;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // PresetsListBox
            // 
            PresetsListBox.FormattingEnabled = true;
            PresetsListBox.ItemHeight = 15;
            PresetsListBox.Items.AddRange(new object[] { "Test", "Test2", "Test3" });
            PresetsListBox.Location = new Point(819, 65);
            PresetsListBox.Name = "PresetsListBox";
            PresetsListBox.Size = new Size(215, 679);
            PresetsListBox.TabIndex = 20;
            // 
            // PresetsLabel
            // 
            PresetsLabel.AutoSize = true;
            PresetsLabel.Location = new Point(819, 47);
            PresetsLabel.Name = "PresetsLabel";
            PresetsLabel.Size = new Size(44, 15);
            PresetsLabel.TabIndex = 21;
            PresetsLabel.Text = "Presets";
            // 
            // SavePreset
            // 
            SavePreset.Location = new Point(819, 750);
            SavePreset.Name = "SavePreset";
            SavePreset.Size = new Size(215, 23);
            SavePreset.TabIndex = 22;
            SavePreset.Text = "Save Current Selections as New Preset";
            SavePreset.UseVisualStyleBackColor = true;
            // 
            // DeletePreset
            // 
            DeletePreset.Location = new Point(819, 777);
            DeletePreset.Name = "DeletePreset";
            DeletePreset.Size = new Size(215, 23);
            DeletePreset.TabIndex = 23;
            DeletePreset.Text = "Delete Selected Preset";
            DeletePreset.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 811);
            Controls.Add(DeletePreset);
            Controls.Add(SavePreset);
            Controls.Add(PresetsLabel);
            Controls.Add(PresetsListBox);
            Controls.Add(CopyButton);
            Controls.Add(SetupButton);
            Controls.Add(testingbox);
            Controls.Add(MainTabControl);
            Controls.Add(LinkBox);
            Controls.Add(DownloadButton);
            Controls.Add(LinkLabel);
            Name = "MainForm";
            Text = "test";
            Load += MainForm_Load;
            GeneralGroupBox.ResumeLayout(false);
            GeneralGroupBox.PerformLayout();
            NetworkGroupBox.ResumeLayout(false);
            NetworkGroupBox.PerformLayout();
            GeorestrictionGroupBox.ResumeLayout(false);
            GeorestrictionGroupBox.PerformLayout();
            MainTabControl.ResumeLayout(false);
            Page1.ResumeLayout(false);
            VideoSelectionGroupBox.ResumeLayout(false);
            VideoSelectionGroupBox.PerformLayout();
            Page2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LinkLabel;
        private Button DownloadButton;
        private TextBox LinkBox;
        private GroupBox GeneralGroupBox;
        private Button Update;
        private Button VersionButton;
        private Button HelpButton;
        private CheckBox AbortCheck;
        private CheckBox NoAbortCheck;
        private CheckBox ignoreerrorscheck;
        private TextBox DefaultSearchBox;
        private CheckBox DefaultSearchCheck;
        private CheckBox forcegenericextractorcheck;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox AliasBox;
        private CheckBox AliasCheck;
        private TextBox CompatOptionsBox;
        private CheckBox CompatOptionsCheck;
        private CheckBox NoColorsCheck;
        private CheckBox NoMarkWatchedCheck;
        private CheckBox MarkWatchedCheck;
        private CheckBox NoWaitForVideoCheck;
        private TextBox WaitForVideoBox;
        private CheckBox WaitForVideoCheck;
        private CheckBox NoLiveFromStartCheck;
        private CheckBox LiveFromStartCheck;
        private CheckBox NoFlatPlaylistCheck;
        private CheckBox FlatPlaylistCheck;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private GroupBox NetworkGroupBox;
        private CheckBox checkBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private TextBox SourceAddressBox;
        private CheckBox SourceAddressIPCheck;
        private TextBox SocketTimeoutBox;
        private CheckBox SocketTimeoutCheck;
        private TextBox ProxyTextBox;
        private CheckBox ProxyCheck;
        private GroupBox GeorestrictionGroupBox;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private TextBox GeoBypassIPBlockBox;
        private CheckBox GeoBypassIPBlockCheck;
        private TextBox GeoBypassCountryBox;
        private CheckBox GeoBypassCountryCheck;
        private TextBox GeoVerificationProxyBox;
        private CheckBox GeoVerificationProxyTextCheck;
        private TabControl MainTabControl;
        private TabPage Page1;
        private TabPage Page2;
        private GroupBox VideoSelectionGroupBox;
        private TextBox SkipPlaylistAfterErrorsBox;
        private TextBox MaxDownloadsBox;
        private TextBox DownloadArchiveBox;
        private TextBox MatchFiltersBox;
        private TextBox MaxFileSizeBox;
        private TextBox MinFileSizeBox;
        private TextBox PlaylistItemsBox;
        private CheckBox AgeLimitCheck;
        private CheckBox DownloadArchiveCheck;
        private CheckBox NoDownloadArchiveCheck;
        private CheckBox MaxDownloadsCheck;
        private CheckBox BreakOnExistingCheck;
        private CheckBox BreakOnRejectCheck;
        private CheckBox BreakPerInputCheck;
        private CheckBox SkipPlaylistAfterErrorsCheck;
        private CheckBox NoBreakPerInputCheck;
        private CheckBox MaxFileSizeCheck;
        private CheckBox DateCheck;
        private CheckBox DateBeforeCheck;
        private CheckBox DateAfterCheck;
        private CheckBox MatchFiltersCheck;
        private CheckBox NoMatchFiltersCheck;
        private CheckBox NoPlaylistCheck;
        private CheckBox YesPlaylistCheck;
        private CheckBox MinFileSizeCheck;
        private CheckBox PlaylistItemsCheck;
        private TextBox testingbox;
        private Button SetupButton;
        private GroupBox DownloadGroupBox;
        private Button CopyButton;
        private ListBox PresetsListBox;
        private Label PresetsLabel;
        private Button SavePreset;
        private Button DeletePreset;
    }
}