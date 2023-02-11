namespace yt_gui
{
    partial class SetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocateFilesButton = new System.Windows.Forms.Button();
            this.SetupExplanationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ytdlpdeplabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ytdlplabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LocateFilesButton
            // 
            this.LocateFilesButton.Location = new System.Drawing.Point(227, 126);
            this.LocateFilesButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LocateFilesButton.Name = "LocateFilesButton";
            this.LocateFilesButton.Size = new System.Drawing.Size(96, 22);
            this.LocateFilesButton.TabIndex = 0;
            this.LocateFilesButton.Text = "Locate Files";
            this.LocateFilesButton.UseVisualStyleBackColor = true;
            this.LocateFilesButton.Click += new System.EventHandler(this.DependenciesButton_Click);
            // 
            // SetupExplanationLabel
            // 
            this.SetupExplanationLabel.AutoSize = true;
            this.SetupExplanationLabel.Location = new System.Drawing.Point(6, 4);
            this.SetupExplanationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SetupExplanationLabel.Name = "SetupExplanationLabel";
            this.SetupExplanationLabel.Size = new System.Drawing.Size(352, 15);
            this.SetupExplanationLabel.TabIndex = 1;
            this.SetupExplanationLabel.Text = "This program requires the yt-dlp executable to function properly. \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Follow the links below, download your desired dependencies, then place them in an" +
    " empty folder.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Then locate the folder below.";
            // 
            // ytdlpdeplabel
            // 
            this.ytdlpdeplabel.AutoSize = true;
            this.ytdlpdeplabel.Location = new System.Drawing.Point(11, 91);
            this.ytdlpdeplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ytdlpdeplabel.Name = "ytdlpdeplabel";
            this.ytdlpdeplabel.Size = new System.Drawing.Size(116, 15);
            this.ytdlpdeplabel.TabIndex = 5;
            this.ytdlpdeplabel.TabStop = true;
            this.ytdlpdeplabel.Text = "yt-dlp Dependencies";
            this.ytdlpdeplabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can optionally add dependencies for increased functionality.";
            // 
            // ytdlplabel
            // 
            this.ytdlplabel.AutoSize = true;
            this.ytdlplabel.Location = new System.Drawing.Point(12, 76);
            this.ytdlplabel.Name = "ytdlplabel";
            this.ytdlplabel.Size = new System.Drawing.Size(39, 15);
            this.ytdlplabel.TabIndex = 7;
            this.ytdlplabel.TabStop = true;
            this.ytdlplabel.Text = "yt-dlp";
            this.ytdlplabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 168);
            this.Controls.Add(this.ytdlplabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ytdlpdeplabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetupExplanationLabel);
            this.Controls.Add(this.LocateFilesButton);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LocateFilesButton;
        private Label SetupExplanationLabel;
        private Label label1;
        private Label label2;
        private LinkLabel ytdlpdeplabel;
        private Label label3;
        private LinkLabel ytdlplabel;
    }
}