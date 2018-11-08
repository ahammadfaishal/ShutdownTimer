namespace ShutdownTimer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertShutdownTimeInMinuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontHesitateToTellYourProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1001ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkenergeeLIVEcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookcomdarkenergeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsAOpenSourceSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minuteLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(26, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Shutdown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Abort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertShutdownTimeInMinuteToolStripMenuItem,
            this.dontHesitateToTellYourProblemsToolStripMenuItem,
            this.version1001ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // insertShutdownTimeInMinuteToolStripMenuItem
            // 
            this.insertShutdownTimeInMinuteToolStripMenuItem.Name = "insertShutdownTimeInMinuteToolStripMenuItem";
            this.insertShutdownTimeInMinuteToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.insertShutdownTimeInMinuteToolStripMenuItem.Text = "Insert shutdown time in minute.";
            // 
            // dontHesitateToTellYourProblemsToolStripMenuItem
            // 
            this.dontHesitateToTellYourProblemsToolStripMenuItem.Name = "dontHesitateToTellYourProblemsToolStripMenuItem";
            this.dontHesitateToTellYourProblemsToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.dontHesitateToTellYourProblemsToolStripMenuItem.Text = "Don\'t hesitate to share your problems.";
            // 
            // version1001ToolStripMenuItem
            // 
            this.version1001ToolStripMenuItem.Name = "version1001ToolStripMenuItem";
            this.version1001ToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.version1001ToolStripMenuItem.Text = "Version: 2.0.1.2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem,
            this.darkenergeeLIVEcomToolStripMenuItem,
            this.facebookcomdarkenergeeToolStripMenuItem,
            this.thisIsAOpenSourceSoftwareToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem
            // 
            this.developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem.Name = "developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem";
            this.developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem.Size = new System.Drawing.Size(614, 22);
            this.developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem.Text = "Developer: Faisal AL Mahmud, IDB-BISEW IT Scholarship Project, Round 25, ESAD-C#";
            // 
            // darkenergeeLIVEcomToolStripMenuItem
            // 
            this.darkenergeeLIVEcomToolStripMenuItem.Name = "darkenergeeLIVEcomToolStripMenuItem";
            this.darkenergeeLIVEcomToolStripMenuItem.Size = new System.Drawing.Size(614, 22);
            this.darkenergeeLIVEcomToolStripMenuItem.Text = "dark.energee@LIVE.com";
            // 
            // facebookcomdarkenergeeToolStripMenuItem
            // 
            this.facebookcomdarkenergeeToolStripMenuItem.Name = "facebookcomdarkenergeeToolStripMenuItem";
            this.facebookcomdarkenergeeToolStripMenuItem.Size = new System.Drawing.Size(614, 22);
            this.facebookcomdarkenergeeToolStripMenuItem.Text = "facebook.com/dark.energee";
            // 
            // thisIsAOpenSourceSoftwareToolStripMenuItem
            // 
            this.thisIsAOpenSourceSoftwareToolStripMenuItem.Name = "thisIsAOpenSourceSoftwareToolStripMenuItem";
            this.thisIsAOpenSourceSoftwareToolStripMenuItem.Size = new System.Drawing.Size(614, 22);
            this.thisIsAOpenSourceSoftwareToolStripMenuItem.Text = "Copyright: This is a Open Source Software. You can copy, edit and distribute it w" +
    "ithout any permission.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(151, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.BackColor = System.Drawing.Color.Transparent;
            this.hourLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hourLabel.ImageKey = "(none)";
            this.hourLabel.Location = new System.Drawing.Point(67, 237);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(0, 37);
            this.hourLabel.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.BackColor = System.Drawing.Color.Transparent;
            this.minuteLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.minuteLabel.ImageKey = "(none)";
            this.minuteLabel.Location = new System.Drawing.Point(118, 237);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(0, 37);
            this.minuteLabel.TabIndex = 8;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.secondLabel.ImageKey = "(none)";
            this.secondLabel.Location = new System.Drawing.Point(170, 237);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(0, 37);
            this.secondLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::ShutdownTimer.Properties.Resources.Anonymous_Mirage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(297, 284);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Shutdown Timer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertShutdownTimeInMinuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dontHesitateToTellYourProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerFaisalALMahmudIDBBISEWITScholarshipProjectRound25ESADCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkenergeeLIVEcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1001ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem facebookcomdarkenergeeToolStripMenuItem;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.ToolStripMenuItem thisIsAOpenSourceSoftwareToolStripMenuItem;
    }
}

