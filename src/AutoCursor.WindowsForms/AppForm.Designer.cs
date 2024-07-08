namespace AutoCursor.WindowsForms
{
    partial class AppForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            intervalLabel = new Label();
            intervalNumericUpDown = new NumericUpDown();
            xLabel = new Label();
            xNumericUpDown = new NumericUpDown();
            yLabel = new Label();
            yNumericUpDown = new NumericUpDown();
            startButton = new Button();
            stopButton = new Button();
            contextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intervalNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = "Auto Cursor";
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Auto Cursor";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(99, 76);
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Image = Properties.Resources.media_playback_start;
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(98, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startButton_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Image = Properties.Resources.media_playback_stop;
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(98, 22);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Click += stopButton_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.window_close;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem1_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(184, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Image = Properties.Resources.window_close;
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(93, 22);
            exitToolStripMenuItem1.Text = "E&xit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripProgressBar });
            statusStrip.Location = new Point(0, 214);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(184, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(180, 16);
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // intervalLabel
            // 
            intervalLabel.AutoSize = true;
            intervalLabel.Location = new Point(12, 30);
            intervalLabel.Name = "intervalLabel";
            intervalLabel.Size = new Size(96, 15);
            intervalLabel.TabIndex = 3;
            intervalLabel.Text = "Interval (Second)";
            // 
            // intervalNumericUpDown
            // 
            intervalNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            intervalNumericUpDown.Location = new Point(12, 48);
            intervalNumericUpDown.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            intervalNumericUpDown.Name = "intervalNumericUpDown";
            intervalNumericUpDown.Size = new Size(160, 23);
            intervalNumericUpDown.TabIndex = 4;
            intervalNumericUpDown.ThousandsSeparator = true;
            intervalNumericUpDown.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(12, 80);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(14, 15);
            xLabel.TabIndex = 5;
            xLabel.Text = "X";
            // 
            // xNumericUpDown
            // 
            xNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            xNumericUpDown.Location = new Point(12, 98);
            xNumericUpDown.Name = "xNumericUpDown";
            xNumericUpDown.Size = new Size(160, 23);
            xNumericUpDown.TabIndex = 6;
            xNumericUpDown.ThousandsSeparator = true;
            xNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(12, 130);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(14, 15);
            yLabel.TabIndex = 7;
            yLabel.Text = "Y";
            // 
            // yNumericUpDown
            // 
            yNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            yNumericUpDown.Location = new Point(12, 148);
            yNumericUpDown.Name = "yNumericUpDown";
            yNumericUpDown.Size = new Size(160, 23);
            yNumericUpDown.TabIndex = 8;
            yNumericUpDown.ThousandsSeparator = true;
            yNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // startButton
            // 
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(12, 177);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 9;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Enabled = false;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Location = new Point(97, 177);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 10;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 236);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(yNumericUpDown);
            Controls.Add(yLabel);
            Controls.Add(xNumericUpDown);
            Controls.Add(xLabel);
            Controls.Add(intervalNumericUpDown);
            Controls.Add(intervalLabel);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Something Cursor";
            FormClosing += AppForm_FormClosing;
            Shown += AppForm_Shown;
            contextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)intervalNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private StatusStrip statusStrip;
        private ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Timer timer;
        private Label intervalLabel;
        private NumericUpDown intervalNumericUpDown;
        private Label xLabel;
        private NumericUpDown xNumericUpDown;
        private Label yLabel;
        private NumericUpDown yNumericUpDown;
        private Button startButton;
        private Button stopButton;
    }
}
