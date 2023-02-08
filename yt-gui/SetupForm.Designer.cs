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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LocateFilesButton
            // 
            this.LocateFilesButton.Location = new System.Drawing.Point(422, 269);
            this.LocateFilesButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LocateFilesButton.Name = "LocateFilesButton";
            this.LocateFilesButton.Size = new System.Drawing.Size(178, 47);
            this.LocateFilesButton.TabIndex = 0;
            this.LocateFilesButton.Text = "Locate Files";
            this.LocateFilesButton.UseVisualStyleBackColor = true;
            this.LocateFilesButton.Click += new System.EventHandler(this.DependenciesButton_Click);
            // 
            // SetupExplanationLabel
            // 
            this.SetupExplanationLabel.AutoSize = true;
            this.SetupExplanationLabel.Location = new System.Drawing.Point(11, 9);
            this.SetupExplanationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SetupExplanationLabel.Name = "SetupExplanationLabel";
            this.SetupExplanationLabel.Size = new System.Drawing.Size(716, 32);
            this.SetupExplanationLabel.TabIndex = 1;
            this.SetupExplanationLabel.Text = "This program requires the yt-dlp executable to function properly. \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1061, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Follow the links below, download your desired dependencies, then place them in an" +
    " empty folder.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Then locate the folder below.";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(20, 194);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(237, 32);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "yt-dlp Dependencies";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can optionally add dependencies for increased functionality.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 162);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 32);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yt-dlp";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 358);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetupExplanationLabel);
            this.Controls.Add(this.LocateFilesButton);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
        private LinkLabel linkLabel2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}