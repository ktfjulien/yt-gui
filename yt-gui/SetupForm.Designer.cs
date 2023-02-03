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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DependenciesButton
            // 
            this.DependenciesButton.Location = new System.Drawing.Point(409, 679);
            this.DependenciesButton.Name = "DependenciesButton";
            this.DependenciesButton.Size = new System.Drawing.Size(179, 46);
            this.DependenciesButton.TabIndex = 0;
            this.DependenciesButton.Text = "Dependencies";
            this.DependenciesButton.UseVisualStyleBackColor = true;
            this.DependenciesButton.Click += new System.EventHandler(this.DependenciesButton_Click);
            // 
            // SetupExplanationLabel
            // 
            this.SetupExplanationLabel.AutoSize = true;
            this.SetupExplanationLabel.Location = new System.Drawing.Point(12, 9);
            this.SetupExplanationLabel.Name = "SetupExplanationLabel";
            this.SetupExplanationLabel.Size = new System.Drawing.Size(739, 32);
            this.SetupExplanationLabel.TabIndex = 1;
            this.SetupExplanationLabel.Text = "This program requires multiple dependencies to function properly.  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please click on the links below, then place all executables in an empty folder.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Then locate the folder below.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 32);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yt-dlp";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(437, 753);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(325, 32);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Explanation of Dependencies";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 818);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetupExplanationLabel);
            this.Controls.Add(this.DependenciesButton);
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
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}