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
            this.DependenciesButton = new System.Windows.Forms.Button();
            this.SetupExplanationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DependenciesButton
            // 
            this.DependenciesButton.Location = new System.Drawing.Point(227, 126);
            this.DependenciesButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DependenciesButton.Name = "DependenciesButton";
            this.DependenciesButton.Size = new System.Drawing.Size(96, 22);
            this.DependenciesButton.TabIndex = 0;
            this.DependenciesButton.Text = "Dependencies";
            this.DependenciesButton.UseVisualStyleBackColor = true;
            this.DependenciesButton.Click += new System.EventHandler(this.DependenciesButton_Click);
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
            this.label1.Size = new System.Drawing.Size(519, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Follow the links below, download your desired dependencies, then place them in an" +
    " empty folder";
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
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(11, 91);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(116, 15);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "yt-dlp Dependencies";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yt-dlp";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 168);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetupExplanationLabel);
            this.Controls.Add(this.DependenciesButton);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DependenciesButton;
        private Label SetupExplanationLabel;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}